namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_SteelProfiles : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SteelProfiles", "ProfileHistoryId", "dbo.ProfileHistories");
            DropIndex("dbo.SteelProfiles", new[] { "ProfileHistoryId" });
            AddColumn("dbo.SteelProfiles", "CreatedByUser", c => c.String(maxLength: 100));
            AddColumn("dbo.SteelProfiles", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.SteelProfiles", "OccupiedByUser", c => c.String(maxLength: 100));
            AddColumn("dbo.SteelProfiles", "OccupiedDate", c => c.DateTime());
            AddColumn("dbo.SteelProfiles", "ModifiedByUser", c => c.String(maxLength: 100));
            AddColumn("dbo.SteelProfiles", "ModifiedDate", c => c.DateTime());
            DropColumn("dbo.SteelProfiles", "ProfileHistoryId");
            DropTable("dbo.ProfileHistories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProfileHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedByUser = c.String(maxLength: 100),
                        CreatedDate = c.DateTime(),
                        OccupiedByUser = c.String(maxLength: 100),
                        OccupiedDate = c.DateTime(),
                        ModifiedByUser = c.String(maxLength: 100),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SteelProfiles", "ProfileHistoryId", c => c.Int(nullable: false));
            DropColumn("dbo.SteelProfiles", "ModifiedDate");
            DropColumn("dbo.SteelProfiles", "ModifiedByUser");
            DropColumn("dbo.SteelProfiles", "OccupiedDate");
            DropColumn("dbo.SteelProfiles", "OccupiedByUser");
            DropColumn("dbo.SteelProfiles", "CreatedDate");
            DropColumn("dbo.SteelProfiles", "CreatedByUser");
            CreateIndex("dbo.SteelProfiles", "ProfileHistoryId");
            AddForeignKey("dbo.SteelProfiles", "ProfileHistoryId", "dbo.ProfileHistories", "Id", cascadeDelete: true);
        }
    }
}

namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_SteelProfiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SteelProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Length = c.Single(nullable: false),
                        ProfileDetailsId = c.Int(nullable: false),
                        ProjectInformationsId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        ProfileHistoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProfileDetails", t => t.ProfileDetailsId, cascadeDelete: true)
                .ForeignKey("dbo.ProfileHistories", t => t.ProfileHistoryId, cascadeDelete: true)
                .ForeignKey("dbo.ProjectInformations", t => t.ProjectInformationsId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.ProfileDetailsId)
                .Index(t => t.ProjectInformationsId)
                .Index(t => t.StatusId)
                .Index(t => t.ProfileHistoryId);
            
            CreateTable(
                "dbo.ProfileDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Weigth = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.ProjectInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SteelProfiles", "StatusId", "dbo.Status");
            DropForeignKey("dbo.SteelProfiles", "ProjectInformationsId", "dbo.ProjectInformations");
            DropForeignKey("dbo.SteelProfiles", "ProfileHistoryId", "dbo.ProfileHistories");
            DropForeignKey("dbo.SteelProfiles", "ProfileDetailsId", "dbo.ProfileDetails");
            DropIndex("dbo.SteelProfiles", new[] { "ProfileHistoryId" });
            DropIndex("dbo.SteelProfiles", new[] { "StatusId" });
            DropIndex("dbo.SteelProfiles", new[] { "ProjectInformationsId" });
            DropIndex("dbo.SteelProfiles", new[] { "ProfileDetailsId" });
            DropTable("dbo.Status");
            DropTable("dbo.ProjectInformations");
            DropTable("dbo.ProfileHistories");
            DropTable("dbo.ProfileDetails");
            DropTable("dbo.SteelProfiles");
        }
    }
}

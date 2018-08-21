namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updare_User_Data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nick", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "Nick");
        }
    }
}

namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate_Status : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    SET IDENTITY_INSERT [dbo].[Status] ON
                    INSERT INTO [dbo].[Status] ([ID], [Name]) VALUES (1, N'Ordered')
                    INSERT INTO [dbo].[Status] ([ID], [Name]) VALUES (2, N'In stock')
                    INSERT INTO [dbo].[Status] ([ID], [Name]) VALUES (3, N'On production')
                    INSERT INTO [dbo].[Status] ([ID], [Name]) VALUES (4, N'Occupied')
                    INSERT INTO [dbo].[Status] ([ID], [Name]) VALUES (5, N'Used')
                    SET IDENTITY_INSERT [dbo].[Status] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}

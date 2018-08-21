namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Admin : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Nick], [Phone]) VALUES (N'cefd17ba-b8e3-4bfa-be92-d48c4e8cc729', N'admin@gmail.com', 0, N'AK8Qi9zIpQp1O+4P3RCNpbiS1hStzX99E6e6EDMfBeNbuFIOmDyt/lVlF1PvuXqA9w==', N'c8605df3-d13b-4261-b6ef-3ba2e22141ff', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com', N'Admin', N'886443442')


            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'Admin')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cefd17ba-b8e3-4bfa-be92-d48c4e8cc729', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
            ");
        }
        
        public override void Down()
        {
        }
    }
}

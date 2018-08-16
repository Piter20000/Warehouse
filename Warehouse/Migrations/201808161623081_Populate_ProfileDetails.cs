namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate_ProfileDetails : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    SET IDENTITY_INSERT [dbo].[ProfileDetails] ON
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (1, N'HEA100', CAST( 16.7 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (2, N'HEA120', CAST( 19.9 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (3, N'HEA140', CAST( 24.7 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (4, N'HEA160', CAST( 30.4 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (5, N'HEA180', CAST( 35.5 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (6, N'HEA200', CAST( 42.3 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (7, N'HEA220', CAST( 50.5 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (8, N'HEA240', CAST( 60.3 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (9, N'HEA260', CAST( 68.2 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (10, N'HEA280', CAST( 76.4 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (11, N'HEA300', CAST( 88.3 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (12, N'HEA320', CAST( 97.6 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (13, N'HEA340', CAST( 105 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (14, N'HEA360', CAST( 112 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (15, N'HEA400', CAST( 125 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (16, N'HEA450', CAST( 140 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (17, N'HEA500', CAST( 155 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (18, N'HEA550', CAST( 166 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (19, N'HEA600', CAST( 178 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (20, N'HEA650', CAST( 190 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (21, N'HEA700', CAST( 204 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (22, N'HEA800', CAST( 224 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (23, N'HEA900', CAST( 252 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (24, N'HEA1000', CAST( 272 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (25, N'HEB100', CAST( 20.4 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (26, N'HEB120', CAST( 26.7 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (27, N'HEB140', CAST( 33.7 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (28, N'HEB160', CAST( 42.6 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (29, N'HEB180', CAST( 51.2 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (30, N'HEB200', CAST( 61.3 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (31, N'HEB220', CAST( 71.5 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (32, N'HEB240', CAST( 83.2 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (33, N'HEB260', CAST( 93 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (34, N'HEB280', CAST( 103 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (35, N'HEB300', CAST( 117 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (36, N'HEB320', CAST( 127 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (37, N'HEB340', CAST( 134 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (38, N'HEB360', CAST( 142 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (39, N'HEB400', CAST( 155 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (40, N'HEB450', CAST( 171 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (41, N'HEB500', CAST( 187 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (42, N'HEB550', CAST( 199 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (43, N'HEB600', CAST( 212 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (44, N'HEB650', CAST( 225 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (45, N'HEB700', CAST( 241 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (46, N'HEB800', CAST( 262 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (47, N'HEB900', CAST( 291 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (48, N'HEB1000', CAST( 314 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (49, N'IPE80', CAST( 6 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (50, N'IPE100', CAST( 8.1 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (51, N'IPE120', CAST( 10.4 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (52, N'IPE140', CAST( 12.9 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (53, N'IPE160', CAST( 15.8 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (54, N'IPE180', CAST( 18.8 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (55, N'IPE200', CAST( 22.4 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (56, N'IPE220', CAST( 26.2 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (57, N'IPE240', CAST( 30.7 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (58, N'IPE270', CAST( 36.1 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (59, N'IPE300', CAST( 42.2 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (60, N'IPE330', CAST( 49.1 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (61, N'IPE360', CAST( 57.1 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (62, N'IPE400', CAST( 66.3 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (63, N'IPE450', CAST( 77.6 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (64, N'IPE500', CAST( 91.1 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (65, N'IPE550', CAST( 106 AS Decimal(18, 2)))
                    INSERT INTO [dbo].[ProfileDetails] ([ID], [Name], [Weigth]) VALUES (66, N'IPE600', CAST( 122 AS Decimal(18, 2)))
                    SET IDENTITY_INSERT [dbo].[ProfileDetails] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}

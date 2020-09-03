namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2e388abe-dddb-4694-a39d-bb037c68210c', N'guest@home.com', 0, N'AGtZMMzlXQxgcOGFAtGng4GTqDKmlSdAK75x8EI8pG8dTfM+ToEu6ipewMXuf0ouog==', N'db46a750-61b0-45ed-8deb-35e0aa1a791a', NULL, 0, 0, NULL, 1, 0, N'guest@home.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'449a9bbe-31a8-409d-a9e5-73a77767fb81', N'admin@home.com', 0, N'ACBwLp7N0Aucn8riROwhFFA2/SWrWVLRuoBnqZWjrJ1iywRuE9i/SRAH0fZGGBAUfg==', N'8b666031-4b38-4d3a-9e01-b5aa3183dd9a', NULL, 0, 0, NULL, 1, 0, N'admin@home.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'30c0da62-279f-457c-9ed3-625df78d2fca', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'449a9bbe-31a8-409d-a9e5-73a77767fb81', N'30c0da62-279f-457c-9ed3-625df78d2fca')
");
        }
        
        public override void Down()
        {
        }
    }
}

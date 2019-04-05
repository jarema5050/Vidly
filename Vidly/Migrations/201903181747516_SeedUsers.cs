using System.Web.Razor.Generator;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a8d9f1f-9c8f-419e-8371-9c68d7dc6333', N'quest@vidly.com', 0, N'ADQ6r2TX4ntXwbIFgx/h6SfLSj69yKN+43/5v9UqNSIMddg8VaVcoKglpCqthEUKqA==', N'f465be0c-be3f-46a1-87cc-8ea428f9eeee', NULL, 0, 0, NULL, 1, 0, N'quest@vidly.com')");
            Sql(
                "INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'5ece04fb-9249-4294-9b0d-5743ad11581c', N'admin2@vidly.com', 0, N'AAhuIikFTKZb51wfs/wBOHWJEjFIedQRL9nbvv/iBWmb84kOVT5Zdvt1b+++QezCkA==', N'1e8baae9-2d19-40f9-a953-a6080eefcd4c', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')");
            Sql(
                "INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c364778b-5b1c-4fee-8dd8-7c7140f69836', N'CanManageMovie')");
            Sql(
                "INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ece04fb-9249-4294-9b0d-5743ad11581c', N'c364778b-5b1c-4fee-8dd8-7c7140f69836')");

        }

        public override void Down()
        {
        }
    }
}
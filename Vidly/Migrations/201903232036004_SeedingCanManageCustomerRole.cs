namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingCanManageCustomerRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1c08009d-15cf-40db-a4ea-8f8e932abbf2', N'CanManageCustomer')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c364778b-5b1c-4fee-8dd8-7c7140f69836', N'CanManageMovie')");
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'b31aa1f2-1d4a-4d65-b474-9da03b9221ab', N'admin3@vidly.com', 0, N'AKCysdXjz4gU8dupHjFEZyqd5UZ9/jsxtXE/Mb1+fftgmtULZ/mclecX+CSIQ2hlwA==', N'fb9ec747-64b1-4e66-8c56-76273e40fd82', N'+4885021895', 0, 0, NULL, 1, 0, N'admin3@vidly.com', N'12345')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'c91a3b9b-26b4-488e-92df-11de3a6ff2fa', N'jarema.zhr@gmail.com', 0, NULL, N'37942808-2bea-423c-912f-dce277a4c377', N'+48504856785', 0, 0, NULL, 1, 0, N'jarema.zhr@gmail.com', N'12345')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'da38575a-588a-4882-b560-b9f3ecef244b', N'quest@vidly.com', 0, N'AACYvxtCMpzXX0atuJi7Y3266njW1YhHnPcQB3j7BKGkjl0zHp6wsyYK5bqQ4VIYnA==', N'df2c117d-2485-4f18-a16a-44c9e066393a', N'+48502665741', 0, 0, NULL, 1, 0, N'quest@vidly.com', N'12345')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'ead44dca-4a94-4bac-85fc-99f0803b8ea3', N'admin@vidly.com', 0, N'AAA2QjMrNVnaI01OEMPTcN3baNMllj8K9vDUxdLPjWmX8LjnZm76PhNpo/473fadFg==', N'bec6e10a-80c7-4de9-9120-3ed99d34c71a', N'+4885021895', 0, 0, NULL, 1, 0, N'admin@vidly.com', N'12345')
               ");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b31aa1f2-1d4a-4d65-b474-9da03b9221ab', N'1c08009d-15cf-40db-a4ea-8f8e932abbf2')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ead44dca-4a94-4bac-85fc-99f0803b8ea3', N'1c08009d-15cf-40db-a4ea-8f8e932abbf2')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b31aa1f2-1d4a-4d65-b474-9da03b9221ab', N'c364778b-5b1c-4fee-8dd8-7c7140f69836')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ead44dca-4a94-4bac-85fc-99f0803b8ea3', N'c364778b-5b1c-4fee-8dd8-7c7140f69836')
                ");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumbertoUserRegistration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'c91a3b9b-26b4-488e-92df-11de3a6ff2fa', N'jarema.zhr@gmail.com', 0, NULL, N'37942808-2bea-423c-912f-dce277a4c377', N'+48504856785', 0, 0, NULL, 1, 0, N'jarema.zhr@gmail.com', N'12345')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'da38575a-588a-4882-b560-b9f3ecef244b', N'quest@vidly.com', 0, N'AACYvxtCMpzXX0atuJi7Y3266njW1YhHnPcQB3j7BKGkjl0zHp6wsyYK5bqQ4VIYnA==', N'df2c117d-2485-4f18-a16a-44c9e066393a', N'+48502665741', 0, 0, NULL, 1, 0, N'quest@vidly.com', N'12345')
            ");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
            
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'17f88c69-7243-48e0-a7c8-33d32ba6bf60', N'bryanlibl20@gmail.com', 0, N'AOJ3vmVSL1c1dz0r5aQc7ARqRhGO/rHBkDNjQkDvvyvsVyS4vbAizB4k3NLPAAkBjw==', N'26d206c1-c1f3-4e9d-aaeb-91672866d286', NULL, 0, 0, NULL, 1, 0, N'bryanlibl20@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4db1476c-8831-4101-ae53-f50a98a07e0d', N'admin@vidly.com', 0, N'AA9gLL48xLF8YQwGSM7ec/vlpzq0bhDvNaCULOF9YRNsAMQvjW36Ezf/PA6XbdEGlg==', N'1303619e-75ca-4913-be28-6f0101d766fd', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8389b3fc-2b31-4d1b-ac44-39e0568a53cf', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4db1476c-8831-4101-ae53-f50a98a07e0d', N'8389b3fc-2b31-4d1b-ac44-39e0568a53cf')

");
        }
        
        public override void Down()
        {
        }
    }
}

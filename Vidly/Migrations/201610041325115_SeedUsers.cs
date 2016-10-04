namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4ea37fa1-e139-4d68-aec0-4516823d1d79', N'guest@vidly.com', 0, N'AChxoKpd696Cg5aUEx+heuGjb74d9vZZaIweBjfhtvs5PFNastrydXR4ORwhgAVCTA==', N'407ac918-34a2-4e70-ae1e-3d637ee98586', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e9133f77-390b-4da1-a1d9-e1df109cfd57', N'admin@vidly.com', 0, N'ALcwXvcRbJa7FHhRG+Th+zs8L53LEd5aYsEwXJq9NvVEg1+gaW6HLt4Gz3mPk/J7GQ==', N'900002ea-a1b2-4ee9-91f4-9af5cc5ea7b0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd5fcbc73-b710-407f-8097-21d921dae092', N'CanManageMovie')

                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9133f77-390b-4da1-a1d9-e1df109cfd57', N'd5fcbc73-b710-407f-8097-21d921dae092')");

        }

    public override void Down()
        {
        }
    }
}

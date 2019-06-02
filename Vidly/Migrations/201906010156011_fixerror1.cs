namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixerror1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MembershipTypeDTOes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MembershipTypeDTOes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}

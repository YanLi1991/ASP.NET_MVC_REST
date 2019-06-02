namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixerror : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.MembershipTypeDTOes");
        }
    }
}

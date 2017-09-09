namespace MyCode.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHeaderUserInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeaderUserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserAgent = c.String(),
                        Host = c.String(),
                        AcceptLanguage = c.String(),
                        Cookie = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HeaderUserInfoes");
        }
    }
}

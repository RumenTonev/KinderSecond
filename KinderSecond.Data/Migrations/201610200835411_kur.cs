namespace KinderSecond.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromoCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PromoCodes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.PromoCodes", new[] { "UserId" });
            DropTable("dbo.PromoCodes");
        }
    }
}

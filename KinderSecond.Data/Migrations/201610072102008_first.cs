namespace KinderSecond.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quizs", "PicturePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quizs", "PicturePath");
        }
    }
}

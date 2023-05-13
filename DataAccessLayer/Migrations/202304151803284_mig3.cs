namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seats", "MusaitMi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Seats", "MusaitMi");
        }
    }
}

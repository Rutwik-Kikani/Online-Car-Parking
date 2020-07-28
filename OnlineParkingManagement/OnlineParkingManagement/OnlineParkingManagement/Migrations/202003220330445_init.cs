namespace OnlineParkingManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Firstname", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Mobileno", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Mobileno", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Gender", c => c.String());
            AlterColumn("dbo.Users", "Lastname", c => c.String());
            AlterColumn("dbo.Users", "Firstname", c => c.String());
        }
    }
}

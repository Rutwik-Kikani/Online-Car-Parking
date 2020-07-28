namespace OnlineParkingManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "User_UserId", c => c.Int());
            CreateIndex("dbo.Vehicles", "User_UserId");
            AddForeignKey("dbo.Vehicles", "User_UserId", "dbo.Users", "UserId");
            DropColumn("dbo.Vehicles", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vehicles", "User_UserId", "dbo.Users");
            DropIndex("dbo.Vehicles", new[] { "User_UserId" });
            DropColumn("dbo.Vehicles", "User_UserId");
        }
    }
}

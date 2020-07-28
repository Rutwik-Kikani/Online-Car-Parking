namespace OnlineParkingManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnotatioinsToParkingPlace : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkingPlaces", "ParkingName", c => c.String(nullable: false));
            AlterColumn("dbo.ParkingPlaces", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkingPlaces", "Address", c => c.String());
            AlterColumn("dbo.ParkingPlaces", "ParkingName", c => c.String());
        }
    }
}

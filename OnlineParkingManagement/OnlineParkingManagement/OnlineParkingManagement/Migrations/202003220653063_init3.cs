namespace OnlineParkingManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkingReservations",
                c => new
                    {
                        ParkingReservationId = c.Int(nullable: false, identity: true),
                        Plot = c.Int(nullable: false),
                        Payment = c.Int(nullable: false),
                        TimeArrival = c.DateTime(nullable: false),
                        TimeDeparture = c.DateTime(nullable: false),
                        ParkingPlace_ParkingPlaceId = c.Int(),
                        User_UserId = c.Int(),
                        Vehicle_VehicleId = c.Int(),
                    })
                .PrimaryKey(t => t.ParkingReservationId)
                .ForeignKey("dbo.ParkingPlaces", t => t.ParkingPlace_ParkingPlaceId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_VehicleId)
                .Index(t => t.ParkingPlace_ParkingPlaceId)
                .Index(t => t.User_UserId)
                .Index(t => t.Vehicle_VehicleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkingReservations", "Vehicle_VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.ParkingReservations", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.ParkingReservations", "ParkingPlace_ParkingPlaceId", "dbo.ParkingPlaces");
            DropIndex("dbo.ParkingReservations", new[] { "Vehicle_VehicleId" });
            DropIndex("dbo.ParkingReservations", new[] { "User_UserId" });
            DropIndex("dbo.ParkingReservations", new[] { "ParkingPlace_ParkingPlaceId" });
            DropTable("dbo.ParkingReservations");
        }
    }
}

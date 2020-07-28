namespace OnlineParkingManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkingPlaces",
                c => new
                    {
                        ParkingPlaceId = c.Int(nullable: false, identity: true),
                        ParkingName = c.String(),
                        Address = c.String(),
                        TwoCapacity = c.Int(nullable: false),
                        FourCapacity = c.Int(nullable: false),
                        TwoRate = c.Int(nullable: false),
                        FourRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParkingPlaceId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        Mobileno = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(),
                        ModelName = c.String(),
                        RegistrationNumber = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
            DropTable("dbo.Users");
            DropTable("dbo.ParkingPlaces");
        }
    }
}

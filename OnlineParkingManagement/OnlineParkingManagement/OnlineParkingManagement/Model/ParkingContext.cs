using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineParkingManagement.Model
{
    class ParkingContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ParkingPlace> ParkingPlaces { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ParkingReservation> ParkingReservations { get; set; }
    }
}

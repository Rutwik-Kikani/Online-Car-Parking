using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineParkingManagement.Model
{
    class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleType { get; set; }
        public string ModelName { get; set; }
        public string RegistrationNumber { get; set; }

        public User User { get; set; }
    }
}

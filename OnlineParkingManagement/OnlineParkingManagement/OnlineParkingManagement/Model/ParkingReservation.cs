using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineParkingManagement.Model
{
    class ParkingReservation
    {
        public int ParkingReservationId { get; set; }
        public int Plot { get; set; }
        public int Payment { get; set; }
        public DateTime TimeArrival { get; set; }
        public DateTime TimeDeparture { get; set; }

        public User User { get; set; }
        public Vehicle Vehicle { get; set; }
        public ParkingPlace ParkingPlace { get; set; }
    }
}

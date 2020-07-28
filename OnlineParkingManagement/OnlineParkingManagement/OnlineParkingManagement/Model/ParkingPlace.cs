using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineParkingManagement.Model
{
    class ParkingPlace
    {
        public int ParkingPlaceId { get; set; }
        [Required]
        public string ParkingName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int TwoCapacity { get; set; }
        [Required]
        public int FourCapacity { get; set; }
        [Required]
        public int TwoRate { get; set; }
        [Required]
        public int FourRate { get; set; }
    }
}

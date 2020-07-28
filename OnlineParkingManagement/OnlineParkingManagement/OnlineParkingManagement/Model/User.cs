using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineParkingManagement.Model
{
    class User
    {
        public int UserId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        public string Gender { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Mobileno { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

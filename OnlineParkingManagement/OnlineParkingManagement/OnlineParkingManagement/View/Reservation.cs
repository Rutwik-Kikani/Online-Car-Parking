using OnlineParkingManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineParkingManagement.View
{
    public partial class Reservation : Form
    {
        string parkName;
        ParkingContext db = new ParkingContext();
        public Reservation(string pname)
        {
            InitializeComponent();
            label1.Text = pname + "\nParking Reservation";
            parkName = pname;
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parking = db.ParkingPlaces.Where(x => x.ParkingName == parkName).FirstOrDefault();
            var user = db.Users.Where(x => x.Email == Homepage.usr).FirstOrDefault();

            Vehicle v = new Vehicle();
            v.VehicleType = vtype.Text;
            v.ModelName = vname.Text;
            v.RegistrationNumber = vnumber.Text;
            v.User = user;
            db.Vehicles.Add(v);

            ParkingReservation parkingReservation = new ParkingReservation();
            if (vtype.Text == "2-Wheeler")
            {
                parkingReservation.Payment = parking.TwoRate;
                parkingReservation.Plot = parking.TwoCapacity;
                parking.TwoCapacity = parking.TwoCapacity - 1;
            }
            else
            {
                parkingReservation.Payment = parking.FourRate;
                parkingReservation.Plot = parking.FourCapacity;
                parking.FourCapacity = parking.FourCapacity - 1;
            }
            parkingReservation.TimeArrival = atime.Value;
            parkingReservation.TimeDeparture = dtime.Value;
            parkingReservation.Vehicle = v;
            parkingReservation.ParkingPlace = parking;
            parkingReservation.User = user;
            db.ParkingReservations.Add(parkingReservation);
            db.SaveChanges();

            MessageBox.Show("Your parking reservation is successfull!!\nParking Plot:"+ parkingReservation.Plot +"\nAmount Payable:" + parkingReservation.Payment);
            this.Hide();
            Homepage home = new Homepage(Homepage.usr);
            home.Show();
        }
    }
}

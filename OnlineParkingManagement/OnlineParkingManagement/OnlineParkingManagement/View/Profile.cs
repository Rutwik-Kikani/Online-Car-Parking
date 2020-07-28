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
    public partial class Profile : Form
    {
        ParkingContext db = new ParkingContext();
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            int x = 50, y = 100;
            var parkresv = db.ParkingReservations.Where(w => w.User.Email == Homepage.usr);
            foreach (ParkingReservation pr in parkresv)
            {
                Label l1 = new Label();
                l1.Location = new Point(x, y);
                l1.Font = new Font("Calibri", 12);
                l1.ForeColor = Color.Blue;
                l1.AutoSize = true;
                //l1.Text = pr.User.Email;
                l1.Text += "\n" + pr.TimeArrival + " - " + pr.TimeDeparture;
                this.Controls.Add(l1);
                y += 30;
            }
        }
    }
}

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
    public partial class Homepage : Form
    {
        public static string usr;
        ParkingContext db = new ParkingContext();
        
        public Homepage(string u)
        {
            InitializeComponent();
            usr = u;
        }
        private void Homepage_Load(object sender, EventArgs e)
        {

            //check for Admin
            btnAddPP.Visible = false;
            btnAddPP.Enabled = false;
            if (usr.Equals("admin@domain.com"))
            {
                btnAddPP.Enabled = true;
                btnAddPP.Visible = true;
            }

            //for displaing parking places statically;
            var parkingPlaces = db.ParkingPlaces;
            //int x = 50, y = 100;
            {
                //foreach (ParkingPlace p in parkingPlaces)
                //{

                //    Label l1 = new Label();
                //    l1.Location = new Point(x, y);
                //    l1.Font = new Font("Calibri", 15);
                //    l1.ForeColor = Color.Blue;
                //    l1.AutoSize = true;
                //    l1.Text = p.ParkingName + " - " + p.Address;
                //    this.Controls.Add(l1);

                //    Button b1 = new Button();
                //    b1.Location = new Point(x + 850, y);
                //    b1.Text = "Reserve";
                //    b1.Height = 30;
                //    b1.Width = 80;
                //    b1.Name = p.ParkingName;
                //    b1.Click += (s, EventArgs) => { mybutton_Click(sender, EventArgs, p.ParkingName); };
                //    this.Controls.Add(b1);
                //    y = y + 30;
                //}
            }

            //displaying with help of DataGridView
            dgvPPDetails.ColumnCount = 4;
            dgvPPDetails.Columns[0].Name = "ParkingName";
            dgvPPDetails.Columns[1].Name = "Address";
            dgvPPDetails.Columns[2].Name = "TwoWheelerRate";
            dgvPPDetails.Columns[3].Name = "FourWheelerRate";

            foreach (ParkingPlace p in parkingPlaces)
            {
                string[] row = new string[] { p.ParkingName, p.Address, p.TwoRate.ToString(), p.FourRate.ToString() };
                dgvPPDetails.Rows.Add(row);
            }

            //Add Reserve Button Column
            int columnIndex = 4;
            DataGridViewButtonColumn btnReserveColumn = new DataGridViewButtonColumn();
            btnReserveColumn.HeaderText = "Make Reservation";
            btnReserveColumn.Name = "btnReserveColumn";
            btnReserveColumn.Text = "Reserve";
            btnReserveColumn.UseColumnTextForButtonValue = true;
            dgvPPDetails.Columns.Insert(columnIndex, btnReserveColumn);

            //datagridView Style
            dgvPPDetails.BorderStyle = BorderStyle.None;
            dgvPPDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPPDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPPDetails.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPPDetails.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPPDetails.BackgroundColor = Color.White;
            dgvPPDetails.EnableHeadersVisualStyles = false;
            dgvPPDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPPDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPPDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p1 = new Profile();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void mybutton_Click(object sender, EventArgs e, string pname)
        {
            this.Hide();
            Reservation rs = new Reservation(pname);
            rs.Show();
        }
        private void btnAddPP_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddParkingPlace AddPP = new AddParkingPlace(usr);
            AddPP.Show();
        }

      
        private void dgvPPDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgvPPDetails.Rows[rowIndex];
                string ParkingPlaceName = selectedRow.Cells[0].Value.ToString();
                mybutton_Click(sender, e, ParkingPlaceName);

            }
        }
    }
}

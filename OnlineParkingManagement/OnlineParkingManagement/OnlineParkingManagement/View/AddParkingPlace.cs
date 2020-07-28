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
    public partial class AddParkingPlace : Form
    {
        ParkingContext db = new ParkingContext();
        private string aEmail;
        
        public AddParkingPlace()
        {
            InitializeComponent();

        }
        public AddParkingPlace(string aEmail)
        {
            InitializeComponent();
            this.aEmail = aEmail;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ParkingPlace PP = new ParkingPlace();
                PP.ParkingName = txtParkingName.Text;
                string str = txtAddress.Text;
                str = str.Replace("\n", String.Empty);
                str = str.Replace("\r", String.Empty);
                str = str.Replace("\t", String.Empty);
                //MessageBox.Show(str);
                PP.Address = str;
                PP.TwoCapacity = Int32.Parse(txtTwoCapacity.Text);
                PP.FourCapacity = Int32.Parse(txtFourCapacity.Text);
                PP.TwoRate = Int32.Parse(txtTwoRate.Text);
                PP.FourRate = Int32.Parse(txtFourRate.Text);
                //MessageBox.Show(PP.ParkingName + "," + PP.Address + "," + PP.TwoCapacity + "," + PP.FourCapacity + "," + PP.TwoRate + "," + PP.FourRate + ".");

                db.ParkingPlaces.Add(PP);
                db.SaveChanges();

                this.Hide();
                Homepage home = new Homepage(aEmail);
                home.Show();
            }
        }

        private void txtParkingName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkingName.Text))
            {
                e.Cancel = true;
                txtParkingName.Focus();
                errorProvider2.SetError(txtParkingName, "Required Field please!!");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtParkingName, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider2.SetError(txtAddress, "Required Field please!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtAddress, "");
            }
        }

        private void txtTwoCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTwoCapacity.Text))
            {
                e.Cancel = true;
                txtTwoCapacity.Focus();
                errorProvider2.SetError(txtTwoCapacity, "Required Field please!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtTwoCapacity, "");
            }
        }

        private void txtFourCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFourCapacity.Text))
            {
                e.Cancel = true;
                txtFourCapacity.Focus();
                errorProvider2.SetError(txtFourCapacity, "Required Field please!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtFourCapacity, "");
            }
        }

        private void txtTwoRate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTwoRate.Text))
            {
                e.Cancel = true;
                txtTwoRate.Focus();
                errorProvider2.SetError(txtTwoRate, "Required Field please!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtTwoRate, "");
            }
        }

        private void txtFourRate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFourRate.Text))
            {
                e.Cancel = true;
                txtFourRate.Focus();
                errorProvider2.SetError(txtFourRate, "Required Field please!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtFourRate, "");
            }
        }
    }
}

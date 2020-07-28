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
    public partial class Login : Form
    {
        ParkingContext db = new ParkingContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string uemail = email.Text;
                string upass = password.Text;
                var u = db.Users.Where(x => x.Email == uemail).FirstOrDefault();
                if (u != null)
                {
                    if (u.Password == upass)
                    {
                        MessageBox.Show("You are successfully Logged In");
                        this.Hide();
                        Homepage home = new Homepage(uemail);
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("User not exists");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rg = new Registration();
            rg.Show();
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                e.Cancel = true;
                email.Focus();
                errorProvider1.SetError(email, "email should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(email, "");
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                e.Cancel = true;
                password.Focus();
                errorProvider1.SetError(password, "password should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(password, "");
            }
        }
    }
}

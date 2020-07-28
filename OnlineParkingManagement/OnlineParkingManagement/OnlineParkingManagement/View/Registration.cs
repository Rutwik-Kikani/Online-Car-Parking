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
    public partial class Registration : Form
    {
        ParkingContext db = new ParkingContext();

        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                User user = new User();
                var radioButtons = gender.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                        user.Gender = rb.Text;
                }

                user.Firstname = fname.Text;
                user.Lastname = lname.Text;
                user.Mobileno = mobile.Text;
                user.Email = email.Text;
                user.Password = password.Text;
                //MessageBox.Show(user.Firstname + ',' + user.Lastname + ',' + user.Mobileno + ',' + user.Email + ',' + user.Password + ',' + user.Gender);

                db.Users.Add(user);
                db.SaveChanges();

                this.Hide();
                Homepage home = new Homepage(user.Email);
                home.Show();
            }
        }

        private void fname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                e.Cancel = true;
                fname.Focus();
                errorProvider1.SetError(fname, "first name should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(fname, "");
            }
        }

        private void lname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lname.Text))
            {
                e.Cancel = true;
                lname.Focus();
                errorProvider1.SetError(lname, "last name should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lname, "");
            }
        }

        private void gender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gender.Text))
            {
                e.Cancel = true;
                gender.Focus();
                errorProvider1.SetError(gender, "gender should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(gender, "");
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

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if(password.Text != textBox4.Text)
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "both password should be same");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, "");
            }
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

        private void mobile_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mobile.Text))
            {
                e.Cancel = true;
                mobile.Focus();
                errorProvider1.SetError(mobile, "mobile no should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mobile, "");
            }
        }
    }
}

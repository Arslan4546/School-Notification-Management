using BussinessLayer;
using ModelLayer;
using school_notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class UserApplication : Form
    {
        public UserApplication()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (IsValidated())
            {
                try
                {
                    UserClass user = UserDetails();
                    user = UserBussiness.GetUserVerifiedBusiness(user);
                    if (user.uname && user.upass)
                    {
                        this.Hide();
                        Form1 MainApp = new Form1();
                        MainApp.ShowDialog();
                    }

                    else
                    {
                        if (user.uname == false)
                        {
                            MessageBox.Show("User Name not Correct", "error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            User.Clear();
                            Pass.Clear();
                            User.Focus();
                        }
                        else if (user.upass == false)
                        {
                            MessageBox.Show("Password not Correct", "error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Pass.Clear();
                            Pass.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }


        private bool IsValidated()
        {
            if (User.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User Name required", "error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                User.Clear();
                User.Focus();
                return false;
            }
            if (Pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password required", "error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pass.Clear();
                Pass.Focus();
                return false;

            }
            return true;
        }

        private UserClass UserDetails()
        {

            UserClass user = new UserClass()
            {

                User = User.Text,
                Pass = Pass.Text,
                uname = false,
                upass = false,
            };

            return user;
        }


    }
}

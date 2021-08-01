using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Salon_Management.Controllers;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Views
{
    public partial class Loginview : Form
    {
        public Loginview()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            User user = LoginController.getUser(UserIdTextBox.Text, PasswordTextBox.Text);
            if (user != null)
            {
                if (user.Role == 1 && user.Status=="active")
                {
                    this.Hide();
                    AdminHomeView a = new AdminHomeView();
                    a.Show();

                }

                else
                {

                    MessageBox.Show("Wrong Pass or User Id", "login failed", MessageBoxButtons.OK);
                    UserIdTextBox.Clear();
                    PasswordTextBox.Clear();
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = true;


            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordButton_Click(object sender, EventArgs e)
        {

        }
    }
}

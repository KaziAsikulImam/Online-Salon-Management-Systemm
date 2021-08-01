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
    public partial class ChangePasswordview : Form
    {
        User user;
        public ChangePasswordview(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordview_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NewPasswordTextBox.Text!="")
            {
                LoginController.UpdatePassword(user.Userid, NewPasswordTextBox.Text);
                NewPasswordTextBox.Clear();
                
                MessageBox.Show("password Change", "Cange Password", MessageBoxButtons.OK);
                this.Hide();
                Loginview a = new Loginview();
                a.Show();


            }
            else
            {
                MessageBox.Show("please give new password", "Cange Password", MessageBoxButtons.OK);

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeView a = new AdminHomeView(user);
            a.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }
    }
}

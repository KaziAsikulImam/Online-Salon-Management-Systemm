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
    public partial class AdminHomeView : Form
    {
        User user;
        public AdminHomeView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void ManageAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAdminView a = new ManageAdminView(user);
            a.Show();
        }

        private void ManageEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployeeView a = new ManageEmployeeView(user);
            a.Show();
        }

        private void CheckBillButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBillView a = new CheckBillView(user);
            a.Show();
        }

        private void ManageCatalogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCatalogView a = new ManageCatalogView(user);
            a.Show();
        }

        

        private void PersonalDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalDetailsView a = new PersonalDetailsView(user);
            a.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordview a = new ChangePasswordview(user);
            a.Show();
        }

        private void AdminHomeView_Load(object sender, EventArgs e)
        {

        }
    }
}

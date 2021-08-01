using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Salon_Management.Views
{
    public partial class AdminHomeView : Form
    {
        public AdminHomeView()
        {
            InitializeComponent();
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
            ManageAdminView a = new ManageAdminView();
            a.Show();
        }

        private void ManageEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployeeView a = new ManageEmployeeView();
            a.Show();
        }

        private void CheckBillButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBillView a = new CheckBillView();
            a.Show();
        }

        private void ManageCatalogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCatalogView a = new ManageCatalogView();
            a.Show();
        }

        private void SetupScheduleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetupWorkScheduleView a = new SetupWorkScheduleView();
            a.Show();
        }

        private void PersonalDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalDetailsView a = new PersonalDetailsView();
            a.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordview a = new ChangePasswordview();
            a.Show();
        }
    }
}

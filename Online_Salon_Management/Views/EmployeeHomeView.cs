using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Views
{
    public partial class EmployeeHomeView : Form
    {
        User user;
        public EmployeeHomeView( User u)
        {
            InitializeComponent();
            user = u;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomerView a = new ManageCustomerView(user);
            a.Show();
        }

        private void CheckAllBillButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBillEmployeeView a = new CheckBillEmployeeView(user);
            a.Show();
        }

        private void CheckAllBillLineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckAllBillLineView a = new CheckAllBillLineView(user);
            a.Show();
        }

        private void AllCatalogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckAllCatalogView a = new CheckAllCatalogView(user);
            a.Show();
        }

        private void AllEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckAllEmployeeView a = new CheckAllEmployeeView(user);
            a.Show();
        }

        private void PersonalDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePersonalDetailsView a = new EmployeePersonalDetailsView(user);
            a.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeChangePasswordView a = new EmployeeChangePasswordView(user);
            a.Show();
        }

        private void CreateBillButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBillView a = new CreateBillView(user);
            a.Show();
        }
    }
}

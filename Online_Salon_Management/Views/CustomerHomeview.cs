using System;
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
    public partial class CustomerHomeview : Form
    {
        User user;
        public CustomerHomeview(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void CustomerHomeview_Load(object sender, EventArgs e)
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

        private void PersonalDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPersonalDetailsView a = new CustomerPersonalDetailsView(user);
            a.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerChangePasswordView a = new CustomerChangePasswordView(user);
            a.Show();
        }

        private void SeeAllBillButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSeeAllBill a = new CustomerSeeAllBill(user);
            a.Show();
        }

        private void SeeAllCatalogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSeeAllCatalogView a = new CustomerSeeAllCatalogView(user);
            a.Show();
        }
    }
}

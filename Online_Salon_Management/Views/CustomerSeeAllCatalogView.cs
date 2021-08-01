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
    public partial class CustomerSeeAllCatalogView : Form
    {
        User user;
        public CustomerSeeAllCatalogView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void CustomerSeeAllCatalogView_Load(object sender, EventArgs e)
        {
            ChechAllCatalogDataGridView.DataSource = CatalogController.GetCatalogList();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomeview a = new CustomerHomeview(user);
            a.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

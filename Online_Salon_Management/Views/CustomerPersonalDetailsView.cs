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
    public partial class CustomerPersonalDetailsView : Form
    {
        User user;
        public CustomerPersonalDetailsView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void CustomerPersonalDetailsView_Load(object sender, EventArgs e)
        {

            Customer m = new Customer();
            m = CustomerController.GetCustomer(user.Userid);
            IdTextBox.Text = m.Customer_id;
            NameTextBox.Text = m.Customer_name;
            PhoneTextBox.Text = m.Customer_phone.ToString();
            EmailTextBox.Text = m.Customer_email;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != "")
            {

                CustomerController.UpdateCustomer(IdTextBox.Text, Convert.ToInt32(PhoneTextBox.Text));
                MessageBox.Show("Phone number updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill phone number box", "update", MessageBoxButtons.OK);
            }
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomeview a = new CustomerHomeview(user);
            a.Show();
        }
    }
}

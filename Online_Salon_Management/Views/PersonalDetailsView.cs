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
    
    public partial class PersonalDetailsView : Form
    {
        User user;
        public PersonalDetailsView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeView a = new AdminHomeView(user);
            a.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonalDetailsView_Load(object sender, EventArgs e)
        {
            Admin m = new Admin();
            m = AddAdminController.GetAdmin(user.Userid);
            IdTextBox.Text = m.Adminid1;
            NameTextBox.Text = m.AdminName1;
            PhoneTextBox.Text = m.Adminphonenumber1.ToString();
            EmailTextBox.Text = m.Adminmail1;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(PhoneTextBox.Text!="")
            {

                AddAdminController.UpdateAdmin(IdTextBox.Text, Convert.ToInt32(PhoneTextBox.Text));
                MessageBox.Show("Phone number updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill phone number box", "update", MessageBoxButtons.OK);
            }
        }
    }
}

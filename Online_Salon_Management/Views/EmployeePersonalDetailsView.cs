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
    public partial class EmployeePersonalDetailsView : Form
    {
        User user;
        public EmployeePersonalDetailsView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomeView a = new EmployeeHomeView(user);
            a.Show();
        }

        private void EmployeePersonalDetailsView_Load(object sender, EventArgs e)
        {
            Employee m = new Employee();
            m = AddEmployeeController.GetEmployee(user.Userid);
            IdTextBox.Text = m.Employee_Id;
            NameTextBox.Text = m.Employee_Name;
            PhoneTextBox.Text = m.Employee_Phone.ToString();
            EmailTextBox.Text = m.Employee_Email;
            SalaryTextBox.Text = m.Employee_Salary.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != "")
            {

                AddEmployeeController.UpdateEmployeeSelf(IdTextBox.Text, Convert.ToInt32(PhoneTextBox.Text));
                MessageBox.Show("Phone number updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill phone number box", "update", MessageBoxButtons.OK);
            }
        }
    }
}

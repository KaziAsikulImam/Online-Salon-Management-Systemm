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
    public partial class ManageCustomerView : Form
    {

        User user;
        public string Id;
        public ManageCustomerView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void ManageCustomerView_Load(object sender, EventArgs e)
        {
            ManageCustomerDataGridView.DataSource = CustomerController.GetCustomerList();
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
            EmployeeHomeView a = new EmployeeHomeView(user);
            a.Show();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text != "") && (PhoneTextBox.Text != ""))
            {
                if (EmailTextBox.Text != "")
                {
                    if ((MaleRadioButton.Checked) || (FemaleRadioButton.Checked))
                    {
                        if ((SecurityAnswerTextBox.Text != "") && (PasswordTextBox.Text != ""))
                        {
                            Customer o = new Customer();
                            o.Customer_id = CreateId();
                            o.Customer_name = NameTextBox.Text;
                            try
                            {

                                o.Customer_phone = Convert.ToInt32(PhoneTextBox.Text);
                                o.Customer_email = EmailTextBox.Text;
                                if (MaleRadioButton.Checked)
                                {
                                    o.Customer_gender = "male";

                                }

                                else if (FemaleRadioButton.Checked)
                                {
                                    o.Customer_gender = "Female";

                                }

                                o.Customer_status = "active";

                                User u = new User();
                                u.Userid = o.Customer_id;
                                u.Password = PasswordTextBox.Text;
                                u.Status = "active";
                                u.Role = 3;
                                u.Security = SecurityAnswerTextBox.Text;

                                CustomerController.InsertCustomer(o);
                                LoginController.InsertUser(u);
                                MessageBox.Show("Customer Inserted.Customer id" + o.Customer_id, "Add Customer", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PhoneTextBox.Clear();
                                EmailTextBox.Clear();
                                SecurityAnswerTextBox.Clear();
                                PasswordTextBox.Clear();

                                ManageCustomerDataGridView.DataSource = CustomerController.GetCustomerList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add Customer", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PhoneTextBox.Clear();
                                EmailTextBox.Clear();
                                SecurityAnswerTextBox.Clear();
                                PasswordTextBox.Clear();

                            }

                        }

                    }


                }

            }

        }

        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 100000);
            string a = "C-" + y;
            return a;

        }

        private void ManageCustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = ManageCustomerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox.Text = ManageCustomerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTextBox.Text = ManageCustomerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            EmailTextBox.Text = ManageCustomerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                CustomerController.DeleteCustomer(Id);
                LoginController.DeleteUser(Id);


                NameTextBox.Clear();
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                SecurityAnswerTextBox.Clear();
                PasswordTextBox.Clear();

                ManageCustomerDataGridView.DataSource = CustomerController.GetCustomerList();
                MessageBox.Show("Customer deleted", "Add Customer", MessageBoxButtons.OK);
                Id = null;

            }

            else
            {
                MessageBox.Show("please select an Customer", "Add Customer", MessageBoxButtons.OK);

            }
        }
    }
}

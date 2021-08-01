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
    public partial class ManageEmployeeView : Form
    {
        User user;
        public string Id;
        public ManageEmployeeView(User u)
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageEmployeeView_Load(object sender, EventArgs e)
        {
            ManageEmployeeDataGridView.DataSource = AddEmployeeController.GetEmployeeList();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text != "") && (PhoneTextBox.Text != ""))
            {
                if ((EmailTextBox.Text != "") && (SalaryTextBox.Text !=""))
                {
                    if ((MaleRadioButton.Checked) || (FemaleRadioButton.Checked))
                    {
                        if ((SecurityAnswerTextBox.Text != "") && (PasswordTextBox.Text != ""))
                        {
                            Employee o = new Employee();
                            o.Employee_Id = CreateId();
                            o.Employee_Name = NameTextBox.Text;
                            try
                            {

                                o.Employee_Phone = Convert.ToInt32(PhoneTextBox.Text);
                                o.Employee_Email = EmailTextBox.Text;
                                o.Employee_Salary = Convert.ToInt32(SalaryTextBox.Text);
                                if (MaleRadioButton.Checked)
                                {
                                    o.Employee_Gender = "male";

                                }

                                else if (FemaleRadioButton.Checked)
                                {
                                    o.Employee_Gender = "Female";

                                }

                                o.Employee_Status= "active";

                                User u = new User();
                                u.Userid = o.Employee_Id;
                                u.Password = PasswordTextBox.Text;
                                u.Status = "active";
                                u.Role = 2;
                                u.Security = SecurityAnswerTextBox.Text;

                                AddEmployeeController.InsertEmployee(o);
                                LoginController.InsertUser(u);
                                MessageBox.Show("Employee Inserted.Admin id" + o.Employee_Id, "Add Employee", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PhoneTextBox.Clear();
                                EmailTextBox.Clear();
                                SalaryTextBox.Clear();
                                SecurityAnswerTextBox.Clear();
                                PasswordTextBox.Clear();

                                ManageEmployeeDataGridView.DataSource = AddEmployeeController.GetEmployeeList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "add Employee", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PhoneTextBox.Clear();
                                EmailTextBox.Clear();
                                SalaryTextBox.Clear();
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
            string a = "E-" + y;
            return a;

        }

        private void ManageEmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageEmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = ManageEmployeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox.Text = ManageEmployeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTextBox.Text = ManageEmployeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            EmailTextBox.Text = ManageEmployeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SalaryTextBox.Text = ManageEmployeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            PasswordTextBox.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if ((Id != null) && (SalaryTextBox.Text!=""))
            {
                AddEmployeeController.UpdateEmployee(Id,Convert.ToInt32(SalaryTextBox.Text));
                


                NameTextBox.Clear();
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                SecurityAnswerTextBox.Clear();
                SalaryTextBox.Clear();
                PasswordTextBox.Clear();

                ManageEmployeeDataGridView.DataSource = AddEmployeeController.GetEmployeeList();
                MessageBox.Show("Employee updated", "update Employee", MessageBoxButtons.OK);
                Id = null;

            }

            else
            {
                MessageBox.Show("please select an Employee or valid salary", "update Employee", MessageBoxButtons.OK);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                AddEmployeeController.DeleteEmployee(Id);
                LoginController.DeleteUser(Id);


                NameTextBox.Clear();
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                SecurityAnswerTextBox.Clear();
                SalaryTextBox.Clear();
                PasswordTextBox.Clear();

                ManageEmployeeDataGridView.DataSource = AddEmployeeController.GetEmployeeList();
                MessageBox.Show("Employee deleted", "Delete Employee", MessageBoxButtons.OK);
                Id = null;

            }

            else
            {
                MessageBox.Show("please select an Employee", "Delete Employee", MessageBoxButtons.OK);

            }
        }
    }
}

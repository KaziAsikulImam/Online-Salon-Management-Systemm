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
    public partial class ManageAdminView : Form
    {
        public string Id;
        public ManageAdminView()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ScuritytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text !="") && (PhoneTextBox.Text !=""))
            {
                if (EmailTextBox.Text != "")
                {
                    if ((MaleRadioButton.Checked) || (FemaleRadioButton.Checked))
                    {
                        if((SecurityAnswerTextBox.Text !="") && (PasswordTextBox.Text !=""))
                        {
                            Admin o = new Admin();
                            o.Adminid1 = CreateId();
                            o.AdminName1 = NameTextBox.Text;
                            try
                            {

                                o.Adminphonenumber1 = Convert.ToInt32(PhoneTextBox.Text);
                                o.Adminmail1 = EmailTextBox.Text;
                                if (MaleRadioButton.Checked)
                                {
                                    o.Admingender1 = "male";

                                }

                                else if (FemaleRadioButton.Checked)
                                {
                                    o.Admingender1 = "Female";

                                }

                                o.Status1 = "active";

                                User u = new User();
                                u.Userid = o.Adminid1;
                                u.Password = PasswordTextBox.Text;
                                u.Status = "active";
                                u.Role = 1;
                                u.Security = SecurityAnswerTextBox.Text;

                                AddAdminController.InsertAdmin(o);
                                LoginController.InsertUser(u);
                                MessageBox.Show("Admin Inserted.Admin id" + o.Adminid1, "Add Admin", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PhoneTextBox.Clear();
                                EmailTextBox.Clear();
                                SecurityAnswerTextBox.Clear();
                                PasswordTextBox.Clear();

                                ManageAdminDataGridView.DataSource = AddAdminController.GetAdminList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed","Add Admin", MessageBoxButtons.OK);
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
            string a = "A-" + y;
            return a;

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageAdminView_Load(object sender, EventArgs e)
        {
            ManageAdminDataGridView.DataSource = AddAdminController.GetAdminList();
        }

        private void ManageAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = ManageAdminDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            NameTextBox.Text = ManageAdminDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            PhoneTextBox.Text = ManageAdminDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            EmailTextBox.Text = ManageAdminDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTextBox.Clear();
        }

        private void ManageAdminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                AddAdminController.DeleteAdmin(Id);
                LoginController.DeleteUser(Id);


                NameTextBox.Clear();
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                SecurityAnswerTextBox.Clear();
                PasswordTextBox.Clear();

                ManageAdminDataGridView.DataSource = AddAdminController.GetAdminList();
                MessageBox.Show("Admin deleted", "Add Admin", MessageBoxButtons.OK);
                Id = null;

            }

            else
            {
                MessageBox.Show("please select an admin", "Add Admin", MessageBoxButtons.OK);

            }
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
            AdminHomeView a = new AdminHomeView();
            a.Show();
        }

       
    }
}

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
    public partial class ForgetPasswordView : Form
    {
        public ForgetPasswordView()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if((IdTextBox.Text!="") &&(SecurityAnswerTextBox.Text!="") &&(NewPasswordTextBox.Text!=""))
            {
                User u;
              u=  LoginController.FindUser(IdTextBox.Text, SecurityAnswerTextBox.Text);
               
                if((u!=null) && (u.Userid==IdTextBox.Text))
                {

                    LoginController.UpdatePassword(IdTextBox.Text, NewPasswordTextBox.Text);
                    MessageBox.Show("password Change", "Change Password", MessageBoxButtons.OK);
                    IdTextBox.Clear();
                    SecurityAnswerTextBox.Clear();
                    NewPasswordTextBox.Clear();
                    this.Hide();
                    Loginview a = new Loginview();
                    a.Show();


                }

                else
                {

                    MessageBox.Show("sorry answer not matched", "Change Password", MessageBoxButtons.OK);
                    IdTextBox.Clear();
                    SecurityAnswerTextBox.Clear();
                    NewPasswordTextBox.Clear();

                }


            }

            else
            {
                MessageBox.Show("please fill all field", "Change Password", MessageBoxButtons.OK);
                IdTextBox.Clear();
                SecurityAnswerTextBox.Clear();
                NewPasswordTextBox.Clear();


            }
        }
    }
}

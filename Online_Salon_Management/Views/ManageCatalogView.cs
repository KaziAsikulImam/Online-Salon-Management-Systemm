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
    public partial class ManageCatalogView : Form
    {
        User user;
        public string Id;
        public ManageCatalogView(User u)
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void ManageCatalogView_Load(object sender, EventArgs e)
        {
            ManageCatalogDataGridView.DataSource = CatalogController.GetCatalogList();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text != "") && (TypeTextBox.Text != ""))
            {
                if (PriceTextBox.Text != "")
                {
                   
                            Catalog o = new Catalog();
                            o.Catalog_Id = CreateId();
                            o.Catalog_Name = NameTextBox.Text;
                            try
                            {

                                o.Catalog_Price= Convert.ToInt32(PriceTextBox.Text);
                                o.Catalog_Type = TypeTextBox.Text;
                                

                                o.Catalog_Status = "active";

                                

                                CatalogController.InsertCatalog(o);
                                
                                MessageBox.Show("Catalog Inserted.Catalo id" + o.Catalog_Id, "Add Catalog", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PriceTextBox.Clear();
                                TypeTextBox.Clear();
                                

                                ManageCatalogDataGridView.DataSource = CatalogController.GetCatalogList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add Catalog", MessageBoxButtons.OK);
                                NameTextBox.Clear();
                                PriceTextBox.Clear();
                                TypeTextBox.Clear();
                                

                            }

                        }

                    }


                }

            

        

        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 100000);
            string a = "Ca-" + y;
            return a;

        }

        private void ManageCatalogView_Click(object sender, EventArgs e)
        {

        }

        private void ManageCatalogDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = ManageCatalogDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            TypeTextBox.Text = ManageCatalogDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            NameTextBox.Text = ManageCatalogDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PriceTextBox.Text = ManageCatalogDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if ((Id != null) && (PriceTextBox.Text != ""))
            {
                CatalogController.UpdateCatalog(Id, Convert.ToInt32(PriceTextBox.Text));



                NameTextBox.Clear();
                PriceTextBox.Clear();
                TypeTextBox.Clear();
                

                ManageCatalogDataGridView.DataSource = CatalogController.GetCatalogList();
                MessageBox.Show("Catalog updated", "update Catalog", MessageBoxButtons.OK);
                Id = null;

            }

            else
            {
                MessageBox.Show("please select an Catalog or valid price", "update Catalog", MessageBoxButtons.OK);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                CatalogController.DeleteCatalog(Id);
               


                NameTextBox.Clear();
                PriceTextBox.Clear();
                TypeTextBox.Clear();
             

                ManageCatalogDataGridView.DataSource = CatalogController.GetCatalogList();
                MessageBox.Show("Catalog Deleted", "Delete Catalog", MessageBoxButtons.OK);
                Id = null;

            }

            else
            {
                MessageBox.Show("please select a Catalog", "Delete CatalogS", MessageBoxButtons.OK);

            }
        }
    }
}

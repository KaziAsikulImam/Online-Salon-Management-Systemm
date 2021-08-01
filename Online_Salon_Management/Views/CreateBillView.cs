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
    public partial class CreateBillView : Form
    {
        User user;
        public int count=0;
        public string Id;
        public int totalBill=0;
        //public string Id2;

        public CreateBillView(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void CreateBillView_Load(object sender, EventArgs e)
        {
            Id = CreateId();
            //CreateBillDataGridView.DataSource = BillLineController.GetBillLineList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomeView a = new EmployeeHomeView(user);
            a.Show();
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

        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 100000);
            string a = "B-" + y;
            return a;

        }
        public string CreateId1()
        {
            Random xx = new Random();
            int y = xx.Next(0, 100000);
            string a = "BL-" + y;
            return a;

        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            if ((CatalogIdTextBox.Text != "") &&(CustomerIdTextBox.Text!="") && (EmployeeIdTextBox.Text!=""))
            {
                
             
                    Catalog k = CatalogController.GetCatalog(CatalogIdTextBox.Text);
                    Employee emp = AddEmployeeController.GetEmployee(EmployeeIdTextBox.Text);
                    Customer c = CustomerController.GetCustomer(CustomerIdTextBox.Text);
                    if ((k.Catalog_Id == CatalogIdTextBox.Text) && (emp.Employee_Id == EmployeeIdTextBox.Text) && (c.Customer_id == CustomerIdTextBox.Text))
                    {
                    if (count == 0)
                    {
                        Bill bx = new Bill();
                        BillLine bi = new BillLine();
                        bi.BillLine_id = CreateId1();
                        bi.Bill_id = Id;
                        bi.Catalog_id = k.Catalog_Id;
                        bi.Amount = k.Catalog_Price;

                        bx.Bill_id = Id;
                        bx.Customer_id = CustomerIdTextBox.Text;
                        bx.Employee_id = EmployeeIdTextBox.Text;
                        bx.Amount = 1;
                        bx.Bill_status = "active";

                        BillController.InsertBill(bx);
                        BillLineController.InsertBillLine(bi);
                        totalBill = totalBill + k.Catalog_Price;
                        CustomerIdTextBox.Enabled = false;
                        EmployeeIdTextBox.Enabled = false;
                        CatalogIdTextBox.Clear();
                        count++;

                        CreateBillDataGridView.DataSource = BillLineController.GetBillLineList1(Id);


                    }

                    else
                    {

                        BillLine bi = new BillLine();
                        bi.BillLine_id = CreateId1();
                        bi.Bill_id = Id;
                        bi.Catalog_id = k.Catalog_Id;
                        bi.Amount = k.Catalog_Price;

                        BillLineController.InsertBillLine(bi);
                        totalBill = totalBill + k.Catalog_Price;
                        CustomerIdTextBox.Enabled = false;
                        EmployeeIdTextBox.Enabled = false;
                        CatalogIdTextBox.Clear();
                        count++;

                        CreateBillDataGridView.DataSource = BillLineController.GetBillLineList1(Id);

                    }

                    }

                    else
                    {
                        MessageBox.Show("Invalid catalog or customer or employee", "create bill", MessageBoxButtons.OK);

                    }
                
            }

            else
            {
                MessageBox.Show("pleasefill all field", "create bill", MessageBoxButtons.OK);
            }
        }

        private void MakeBillButton_Click(object sender, EventArgs e)
        {
            if(totalBill!=0)
            {
                
               
                BillController.UpdateBill(Id,totalBill);
                TotalBillTextBox.Text = totalBill.ToString();
                MessageBox.Show("BILL iD:"+Id, "create bill", MessageBoxButtons.OK);

                CatalogIdTextBox.Clear();
                EmployeeIdTextBox.Clear();
                CustomerIdTextBox.Clear();

            }

            else
            {

                MessageBox.Show("pleasefill all field", "create bill", MessageBoxButtons.OK);

            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if((CnameTextBox.Text!="" ) &&(CnameRadioButton.Checked))
            {

                SearchDataGridView.DataSource = CustomerController.GetCustomerList1(CnameTextBox.Text);
                CnameTextBox.Clear();
                catanameTextBox.Clear();
                EnameTextBox.Clear();

            }

            else if ((catanameTextBox.Text!="") && (CatanameRadioButton.Checked))
            {
                //Catalog F = new Catalog();
               // F=CatalogController.GetCatalogList1(catanameTextBox.Text);
                SearchDataGridView.DataSource = CatalogController.GetCatalogList1(catanameTextBox.Text);
                //MessageBox.Show("Catalog id:"+F.Catalog_Id);

                CnameTextBox.Clear();
                catanameTextBox.Clear();
                EnameTextBox.Clear();
            }

            else if((EnameTextBox.Text!="")&&(EnameRadioButton.Checked))
            {
               SearchDataGridView.DataSource = AddEmployeeController.GetEmployeeList1(EnameTextBox.Text);
                CnameTextBox.Clear();
                catanameTextBox.Clear();
                EnameTextBox.Clear();
            }
        }
    }
}

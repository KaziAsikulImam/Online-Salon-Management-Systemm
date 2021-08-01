using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
    public class CustomerController
    {
        static Database db = new Database();

        static public void InsertCustomer(Customer cs)
        {

            db.Customers.InsertCustomer(cs);



        }

        static public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = db.Customers.GetCustomerList();
            return customerList;

        }

        static public List<Customer> GetCustomerList1(string name)
        {
            List<Customer> customerList = db.Customers.GetCustomerList1( name);
            return customerList;

        }

        static public Customer GetCustomer(string id)
        {
            Customer a = new Customer();
            a = db.Customers.GetCustomer(id);
            return a;

        }

        

        static public void UpdateCustomer(String Id, int Phoneno)
        {

            db.Customers.UpdateCustomer(Id, Phoneno);


        }

        static public void DeleteCustomer(String Id)
        {
            db.Customers.DeleteCustomer(Id);


        }

    }
}

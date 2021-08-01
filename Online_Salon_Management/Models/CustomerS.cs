using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace Online_Salon_Management.Models
{
   public class CustomerS
    {
        public void InsertCustomer(Customer cs)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO Customer VALUES(@Cus_id,@Cus_name,@Cus_phone,@Cus_mail,@Cus_gender,@Cus_status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Cus_id", cs.Customer_id);
            cmd.Parameters.AddWithValue("@Cus_name", cs.Customer_name);
            cmd.Parameters.AddWithValue("@Cus_phone", cs.Customer_phone);
            cmd.Parameters.AddWithValue("@Cus_mail", cs.Customer_email);
            cmd.Parameters.AddWithValue("@Cus_gender", cs.Customer_gender);
            cmd.Parameters.AddWithValue("@Cus_status", cs.Customer_status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Customer> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> list = new List<Customer>();
            using (reader)
            {

                while (reader.Read())
                {
                    Customer obj = new Customer();
                    obj.Customer_id = reader.GetString(0);
                    obj.Customer_name = reader.GetString(1);
                    obj.Customer_phone = reader.GetInt32(2);
                    obj.Customer_email = reader.GetString(3);
                    obj.Customer_gender = reader.GetString(4);
                    obj.Customer_status = reader.GetString(5);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Customer GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Customer obj = new Customer();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.Customer_id = reader.GetString(0);
                    obj.Customer_name = reader.GetString(1);
                    obj.Customer_phone = reader.GetInt32(2);
                    obj.Customer_email = reader.GetString(3);
                    obj.Customer_gender = reader.GetString(4);
                    obj.Customer_status = reader.GetString(5);

                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Customer> GetCustomerList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Customer WHERE Cus_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Customer> CustomerList = GetData(cmd);
            return CustomerList;




        }

        public List<Customer> GetCustomerList1(String name)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Customer WHERE Cus_name=@name and Cus_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", "active");

            List<Customer> CustomerList = GetData(cmd);
            return CustomerList;


        }

        public Customer GetCustomer(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Customer WHERE Cus_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Customer customer = new Customer();
            customer = GetData1(cmd);

            return customer;


        }

        


        public void DeleteCustomer(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Customer SET Cus_status=@status WHERE Cus_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateCustomer(String Id, int Phoneno)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Customer SET Cus_phone=@Phoneno WHERE Cus_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@Phoneno", Phoneno);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

    }
}

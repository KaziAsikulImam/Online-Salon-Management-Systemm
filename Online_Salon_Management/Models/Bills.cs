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
    public class Bills
    {
        public List<Bill> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Bill> list = new List<Bill>();
            using (reader)
            {
                while (reader.Read())
                {
                    Bill obj = new Bill();
                    obj.Bill_id = reader.GetString(0);
                    obj.Customer_id = reader.GetString(1);
                    obj.Employee_id= reader.GetString(2);
                    obj.Amount = reader.GetInt32(3);
                    obj.Bill_status= reader.GetString(4);


                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }

        public List<Bill> GetBillList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Bill WHERE Bill_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Bill> billList = GetData(cmd);
            return billList;
        }

        public List<Bill> GetBillList1(String Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Bill WHERE Cus_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            List<Bill> billList = GetData(cmd);
            return billList;
        }

        public void InsertBill(Bill bill)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO Bill VALUES(@Bill_id,@Cus_id,@Emp_id,@Amount,@Bill_status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Bill_id",bill.Bill_id);
            cmd.Parameters.AddWithValue("@Cus_id", bill.Customer_id);
            cmd.Parameters.AddWithValue("@Emp_id", bill.Employee_id);
            cmd.Parameters.AddWithValue("@Amount", bill.Amount);
           
            cmd.Parameters.AddWithValue("@Bill_status", bill.Bill_status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void UpdateBill(String Id, int totalbill)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Bill SET Amount=@amount WHERE Bill_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@amount", totalbill);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }





    }
}

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
    public class BillLines
    {
        public List<BillLine> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<BillLine> list = new List<BillLine>();
            using (reader)
            {
                while (reader.Read())
                {
                    BillLine obj = new BillLine();
                    obj.BillLine_id = reader.GetString(0);
                    obj.Bill_id = reader.GetString(1);
                    obj.Catalog_id = reader.GetString(2);
                    obj.Amount = reader.GetInt32(3);
                   


                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }

        public List<BillLine> GetBillLineList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from BillLine ");
            cmd.CommandType = CommandType.Text;
            
            List<BillLine> billList = GetData(cmd);
            return billList;
        }

        

        public void InsertBillLine(BillLine bill)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO BillLine VALUES(@BillLine_id,@Bill_id,@Catalog_id,@Amount)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@BillLine_id", bill.BillLine_id);
            cmd.Parameters.AddWithValue("@Bill_id", bill.Bill_id);
            cmd.Parameters.AddWithValue("@Catalog_id", bill.Catalog_id);
            cmd.Parameters.AddWithValue("@Amount", bill.Amount);

       

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<BillLine> GetBillLineList1(String Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from BillLine WHERE Bill_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            List<BillLine> billList = GetData(cmd);
            return billList;
        }
    }
}

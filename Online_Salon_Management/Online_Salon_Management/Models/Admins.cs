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
    public class Admins
    {
        public void InsertAdmin(Admin admin)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO Admin VALUES(@id,@name,@phone,@mail,@gender,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", admin.Adminid1);
            cmd.Parameters.AddWithValue("@name", admin.AdminName1);
            cmd.Parameters.AddWithValue("@phone", admin.Adminphonenumber1);
            cmd.Parameters.AddWithValue("@mail", admin.Adminmail1);
            cmd.Parameters.AddWithValue("@gender", admin.Admingender1);
            cmd.Parameters.AddWithValue("@status", admin.Status1);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Admin> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Admin> list = new List<Admin>();
            using (reader)
            {

                while (reader.Read())
                {
                    Admin obj = new Admin();
                    obj.Adminid1 = reader.GetString(0);
                    obj.AdminName1 = reader.GetString(1);
                    obj.Adminphonenumber1 = reader.GetInt32(2);
                    obj.Adminmail1 = reader.GetString(3);
                    obj.Admingender1 = reader.GetString(4);
                    obj.Status1 = reader.GetString(5);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public List<Admin> GetAdminList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Admin WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Admin> adminList = GetData(cmd);
            return adminList;


        }


        public void DeleteAdmin(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Admin SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateAdmin(String Id, int Phoneno)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Admin SET phone=@Phoneno WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@Phoneno", Phoneno);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

    }
}

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
   public class Catalogs
    {
        public void InsertCatalog(Catalog cata)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO Catalog VALUES(@Catalog_id,@Catalog_type,@Catalog_name,@Catalog_price,@Catalog_status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Catalog_id", cata.Catalog_Id);
            cmd.Parameters.AddWithValue("@Catalog_type", cata.Catalog_Type);
            cmd.Parameters.AddWithValue("@Catalog_name", cata.Catalog_Name);
            cmd.Parameters.AddWithValue("@Catalog_price", cata.Catalog_Price);
            cmd.Parameters.AddWithValue("@Catalog_status", cata.Catalog_Status);
           

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Catalog> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Catalog> list = new List<Catalog>();
            using (reader)
            {

                while (reader.Read())
                {
                    Catalog obj = new Catalog();
                    obj.Catalog_Id = reader.GetString(0);
                    obj.Catalog_Type = reader.GetString(1);
                    obj.Catalog_Name = reader.GetString(2);
                  
                    obj.Catalog_Price = reader.GetInt32(3);
                    obj.Catalog_Status = reader.GetString(4);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public List<Catalog> GetCatalogList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Catalog WHERE Catalog_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Catalog> CatalogList = GetData(cmd);
            return CatalogList;


        }


        public void DeleteCatalog(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Catalog SET Catalog_status=@status WHERE Catalog_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateCatalog(String Id, int Price)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Catalog SET Catalog_price=@Price WHERE Catalog_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public Catalog GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Catalog obj = new Catalog();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.Catalog_Id = reader.GetString(0);
                    obj.Catalog_Type = reader.GetString(1);
                    obj.Catalog_Name = reader.GetString(2);
                    obj.Catalog_Price = reader.GetInt32(3);
              
                    obj.Catalog_Status = reader.GetString(4);

                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public Catalog GetCatalog(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Catalog WHERE Catalog_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Catalog ct = new Catalog();
            ct = GetData1(cmd);

            return ct;


        }

        public List<Catalog> GetCatalogList1(string name)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Catalog WHERE Catalog_name=@name and Catalog_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Catalog> CatalogList = GetData(cmd);

            return CatalogList;


        }
    }
}

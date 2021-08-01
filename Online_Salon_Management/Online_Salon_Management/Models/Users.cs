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
    public class Users
    {
        public User getUser(string userId, string password)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Login WHERE userid= '"+userId+"' and password='"+password+"'");
            User user = new User();
            user = GetData(cmd);
            return user;

        }

        User GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            User obj=new User();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.Userid = reader.GetString(0);
                    obj.Password = reader.GetString(1);
                    obj.Role = reader.GetInt32(2);
                    obj.Status = reader.GetString(3);
                    
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public void InsertUser(User user)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO Login VALUES(@userid,@password,@role,@status,@security)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userid", user.Userid);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@status", user.Status);
            cmd.Parameters.AddWithValue("@security", user.Security);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void DeleteUser(string userId)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Login SET status=@status WHERE userid=@userid");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userid", userId);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public User FindUser(string userid, string security)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd=da.GetCommand("SELECT * from Login WHERE userid='"+userid +"' and security='"+security+"'");
            User user = new User();
            user = GetData(cmd);
            return user;



        }


                }

            }


        
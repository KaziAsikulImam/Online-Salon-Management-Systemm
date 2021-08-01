using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Online_Salon_Management.Models
{
    public class SqlDbDataAccess
    {
        private const string V = @"Data Source=DESKTOP-801VOQC\SQLEXPRESS;Initial Catalog=Salon;Integrated Security=True";
        const string Connectionstring = V;


        public SqlCommand GetCommand(string query)
        {
            var connection = new SqlConnection(Connectionstring);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}

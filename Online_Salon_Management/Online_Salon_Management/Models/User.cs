using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
   public class User
    {
        string userid;

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

       

        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        int role;

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string security;

        public string Security
        {
            get { return security; }
            set { security = value; }
        }

    }
}

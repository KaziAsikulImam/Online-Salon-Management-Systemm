using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
    public class Database
    {
        public Users Users { get; set; }
        public Admins Admins { get; set; }

        public Database()
        {
            Users=new Users();
            Admins = new Admins();

        }
    }
}

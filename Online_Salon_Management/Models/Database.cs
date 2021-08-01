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

        public Employees Employees { get; set; }

        public Catalogs Catalogs { get; set; }

        public CustomerS Customers { get; set; }

        public Bills Bills { get; set; }

        public BillLines BillLines {get; set;}
        public Database()
        {
            Users=new Users();
            Admins = new Admins();
            Employees = new Employees();
            Catalogs = new Catalogs();
            Customers = new CustomerS();
            Bills = new Bills();
            BillLines = new BillLines();

        }
    }
}

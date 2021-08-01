using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
    public class Bill
    {
        string bill_id;

        public string Bill_id { get => bill_id; set => bill_id = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }

        
        public string Employee_id { get => employee_id; set => employee_id = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Bill_status { get => bill_status; set => bill_status = value; }
        

        string customer_id;
       
        string employee_id;
        int amount;
        string bill_status;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
    public class Customer
    {
        string customer_id;

        public string Customer_id { get => customer_id; set => customer_id = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public int Customer_phone { get => customer_phone; set => customer_phone = value; }
        public string Customer_email { get => customer_email; set => customer_email = value; }
        public string Customer_gender { get => customer_gender; set => customer_gender = value; }
        public string Customer_status { get => customer_status; set => customer_status = value; }

        string customer_name;
        int customer_phone;
        string customer_email;
        string customer_gender;
        string customer_status;

    }
}

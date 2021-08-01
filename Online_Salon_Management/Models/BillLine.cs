using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
    public class BillLine
    {
        string billLine_id;

        public string BillLine_id { get => billLine_id; set => billLine_id = value; }
        public string Bill_id { get => bill_id; set => bill_id = value; }
        public string Catalog_id { get => catalog_id; set => catalog_id = value; }
        public int Amount { get => amount; set => amount = value; }

        string bill_id;
        string catalog_id;
        int amount;
        

    }
}

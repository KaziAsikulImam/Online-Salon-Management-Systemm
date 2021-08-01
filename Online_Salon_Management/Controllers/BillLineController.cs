using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
    public class BillLineController
    {

        static Database db = new Database();

        static public void InsertBillLine(BillLine bill)
        {

            db.BillLines.InsertBillLine(bill);


        }

        static public List<BillLine> GetBillLineList()
        {
            List<BillLine> BillList = db.BillLines.GetBillLineList();
            return BillList;

        }

        static public List<BillLine> GetBillLineList1(string id)
        {
            List<BillLine> BillList = db.BillLines.GetBillLineList1(id);
            return BillList;

        }


    }
}

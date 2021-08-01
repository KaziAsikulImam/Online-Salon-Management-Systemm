using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
    public class BillController
    {
        static Database db = new Database();

        static public void InsertBill(Bill bill)
        {

            db.Bills.InsertBill(bill);


        }


        static public void UpdateBill(string id,int amount)
        {

            db.Bills.UpdateBill(id,amount);


        }

        static public List<Bill> GetBillList()
        {
            List<Bill> BillList = db.Bills.GetBillList();
            return BillList;

        }

        static public List<Bill> GetBillList1(string Id)
        {
            List<Bill> BillList = db.Bills.GetBillList1(Id);
            return BillList;

        }




    }
}

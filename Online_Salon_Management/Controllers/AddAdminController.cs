using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
    public class AddAdminController
    {
        static Database db = new Database();

        static public void InsertAdmin(Admin admin)
        {

             db.Admins.InsertAdmin(admin);
            

        }

        static public List<Admin> GetAdminList()
        {
            List<Admin>adminList=db.Admins.GetAdminList();
            return adminList;
            
        }

        static public Admin GetAdmin(string id)
        {
            Admin a = new Admin();
           a = db.Admins.GetAdmin(id);
            return a;

        }

        static public void UpdateAdmin(String Id, int Phoneno)
        {

            db.Admins.UpdateAdmin(Id, Phoneno);


        }

        static public void DeleteAdmin(String Id)
        {
            db.Admins.DeleteAdmin(Id);


        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
   public class LoginController
    {
       static Database db = new Database();

       static public dynamic getUser(string userid, string password)
       {

           var obj = db.Users.getUser(userid, password);
           return obj;

       }

       static public void InsertUser(User user)
       {
           db.Users.InsertUser(user);

       }

       static public void DeleteUser(string userid)
       {
           db.Users.DeleteUser(userid);

       }
       static public User FindUser(string id, string security)
       {
           User obj = db.Users.FindUser(id, security);
           return obj;

       }

        static public void UpdatePassword(string userid,string Password)
        {
            db.Users.Update_Password(userid,Password);

        }

    }
}

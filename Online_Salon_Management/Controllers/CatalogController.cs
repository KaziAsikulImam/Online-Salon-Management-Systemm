using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
   public  class CatalogController
    {
        static Database db = new Database();

        static public void InsertCatalog(Catalog cata)
        {

            db.Catalogs.InsertCatalog(cata);


        }

        static public List<Catalog> GetCatalogList()
        {
            List<Catalog> CatalogList = db.Catalogs.GetCatalogList();

            return CatalogList;

        }

        static public List<Catalog> GetCatalogList1(string name)
        {
            List<Catalog> CatalogList = db.Catalogs.GetCatalogList1( name);

            return CatalogList;

        }

        static public void UpdateCatalog(String Id, int Price)
        {

            db.Catalogs.UpdateCatalog(Id, Price);



        }

       

        static public void DeleteCatalog(String Id)
        {
            db.Catalogs.DeleteCatalog(Id);


        }

        static public Catalog GetCatalog(string id)
        {
            Catalog a = new Catalog();
            a = db.Catalogs.GetCatalog(id);
            return a;

        }

        

    }
}

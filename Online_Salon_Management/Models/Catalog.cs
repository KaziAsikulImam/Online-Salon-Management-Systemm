using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
    public class Catalog
    {
        string catalog_Id;

        public string Catalog_Id { get => catalog_Id; set => catalog_Id = value; }
        public string Catalog_Type { get => catalog_Type; set => catalog_Type = value; }
        public string Catalog_Name { get => catalog_Name; set => catalog_Name = value; }
        public int Catalog_Price { get => catalog_Price; set => catalog_Price = value; }
        public string Catalog_Status { get => catalog_Status; set => catalog_Status = value; }

        string catalog_Type;
        string catalog_Name;
        int catalog_Price;
        string catalog_Status;
    }
}

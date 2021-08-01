using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Salon_Management.Models
{
   public  class Employee
    {
        string employee_Id;

        public string Employee_Id { get => employee_Id; set => employee_Id = value; }
        public string Employee_Name { get => employee_Name; set => employee_Name = value; }
        public int Employee_Phone { get => employee_Phone; set => employee_Phone = value; }
        public string Employee_Email { get => employee_Email; set => employee_Email = value; }
        public string Employee_Gender { get => employee_Gender; set => employee_Gender = value; }
        public int Employee_Salary { get => employee_Salary; set => employee_Salary = value; }
        public string Employee_Status { get => employee_Status; set => employee_Status = value; }

        string employee_Name;

        int employee_Phone;

        string employee_Email;
        string employee_Gender;
        int employee_Salary;
        string employee_Status;
    }
}

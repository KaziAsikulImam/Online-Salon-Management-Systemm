using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Salon_Management.Models;

namespace Online_Salon_Management.Controllers
{
    class AddEmployeeController
    {
        static Database db = new Database();

        static public void InsertEmployee(Employee emp)
        {

            db.Employees.InsertEmployee(emp);


        }

        static public List<Employee> GetEmployeeList()
        {
            List<Employee> EmployeeList = db.Employees.GetEmployeeList();
            return EmployeeList;

        }

        static public List<Employee> GetEmployeeList1(string name)
        {
            List<Employee> EmployeeList = db.Employees.GetEmployeeList1(name);
            return EmployeeList;

        }

        static public void UpdateEmployeeSelf(String Id, int Phoneno)
        {

            db.Employees.UpdateEmployeeSelf(Id, Phoneno);


        }

        static public void UpdateEmployee(String Id, int salary)
        {

            db.Employees.UpdateEmployee(Id, salary);


        }

        static public void DeleteEmployee(String Id)
        {
            db.Employees.DeleteEmployee(Id);


        }

        static public Employee GetEmployee(string id)
        {
            Employee a = new Employee();
            a = db.Employees.GetEmployee(id);
            return a;

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace Online_Salon_Management.Models
{
   public class Employees
    {
        public void InsertEmployee(Employee emp)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO Employee VALUES(@Emp_id,@Emp_name,@Emp_phone,@Emp_mail,@Emp_gender,@Emp_salary,@Emp_status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Emp_id", emp.Employee_Id);
            cmd.Parameters.AddWithValue("@Emp_name", emp.Employee_Name);
            cmd.Parameters.AddWithValue("@Emp_phone", emp.Employee_Phone);
            cmd.Parameters.AddWithValue("@Emp_mail", emp.Employee_Email);
            cmd.Parameters.AddWithValue("@Emp_gender", emp.Employee_Gender);
            cmd.Parameters.AddWithValue("@Emp_salary", emp.Employee_Salary);
            cmd.Parameters.AddWithValue("@Emp_status", emp.Employee_Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Employee> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> list = new List<Employee>();
            using (reader)
            {

                while (reader.Read())
                {
                    Employee obj = new Employee();
                    obj.Employee_Id = reader.GetString(0);
                    obj.Employee_Name = reader.GetString(1);
                    obj.Employee_Phone = reader.GetInt32(2);
                    obj.Employee_Email = reader.GetString(3);
                    obj.Employee_Gender = reader.GetString(4);
                    obj.Employee_Salary = reader.GetInt32(5);
                    obj.Employee_Status = reader.GetString(6);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public List<Employee> GetEmployeeList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Employee WHERE Emp_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Employee> EmployeeList = GetData(cmd);
            return EmployeeList;


        }

        public List<Employee> GetEmployeeList1(string name)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Employee WHERE Emp_name=@name and Emp_status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Employee> EmployeeList = GetData(cmd);
            return EmployeeList;


        }


        public void DeleteEmployee(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Employee SET Emp_status=@status WHERE Emp_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateEmployeeSelf(String Id, int Phoneno)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Employee SET Emp_phone=@Phoneno WHERE Emp_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@Phoneno", Phoneno);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void UpdateEmployee(String Id, int salary)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE Employee SET Emp_salary=@salary WHERE Emp_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }


        public Employee GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Employee obj = new Employee();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.Employee_Id = reader.GetString(0);
                    obj.Employee_Name = reader.GetString(1);
                    obj.Employee_Phone = reader.GetInt32(2);
                    obj.Employee_Email = reader.GetString(3);
                    obj.Employee_Gender = reader.GetString(4);
                    obj.Employee_Salary = reader.GetInt32(5);
                    obj.Employee_Status = reader.GetString(6);

                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public Employee GetEmployee(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Employee WHERE Emp_id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Employee emp = new Employee();
            emp = GetData1(cmd);

            return emp;


        }

        


    }
}

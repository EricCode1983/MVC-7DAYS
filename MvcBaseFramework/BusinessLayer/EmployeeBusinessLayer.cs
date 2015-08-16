using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    { 
        
        public List<Employee> GetEmployees()
    {
        List<Employee><employee> employees = new List<Employee><employee>();
        Employee emp = new Employee();
        emp.FirstName = "johnson";
        emp.LastName = " fernandes";
        emp.Salary = 14000;
        employees.Add(emp);
    }
}

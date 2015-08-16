using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1.DataAccessLayer;
namespace Test1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesErpdal salesDal = new SalesErpdal();
            return salesDal.Employees.ToList();
       
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;
using Test1.ViewModel;


namespace Test1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Welcome to mvc";
        }

        public ActionResult GetView()
        {

            EmployeeListViewModel employeeListViewModel= GetView2();
            return View("MyView", employeeListViewModel);
        }


        private EmployeeListViewModel GetView2()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "Admin";
            return employeeListViewModel;
        }
    private EmployeeViewModel GetView1()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
            ViewData["Employee"] = emp;
            ViewBag.Employe = emp;

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
            var salary = emp.Salary;
            employeeViewModel.SalaryColor = salary > 15000 ? "red" : "yellow";
            employeeViewModel.Salary = emp.Salary.ToString("C");
            return employeeViewModel;
        }
        public ActionResult GetContent()
        {
            return Content("Hi Welcome");
        }
    }
}
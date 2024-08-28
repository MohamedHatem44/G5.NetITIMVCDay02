using G5.NetITIMVCDay02.Models;
using Microsoft.AspNetCore.Mvc;

namespace G5.NetITIMVCDay02.Controllers
{
    public class EmployeeController : Controller
    {
        /*----------------------------------------------------------------------*/
        // DataBase
        static List<Employee> _Employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ramy", Age = 22, Salary = 1234 },
                new Employee { Id = 2, Name = "Mai", Age = 32, Salary = 2234 },
                new Employee { Id = 3, Name = "Ali", Age = 42, Salary = 3234 },
                new Employee { Id = 4, Name = "Omar", Age = 52, Salary = 4234 },
                new Employee { Id = 5, Name = "Mostafa", Age = 28, Salary = 5234 },
                new Employee { Id = 6, Name = "Ahmed", Age = 38, Salary = 6234 },
                new Employee { Id = 7, Name = "Sara", Age = 48, Salary = 7234 },
                new Employee { Id = 8, Name = "Osama", Age = 26, Salary = 8234 },
                new Employee { Id = 9, Name = "Mohamed", Age = 36, Salary = 9234 },
                new Employee { Id = 10, Name = "Nour", Age = 46, Salary = 10234 },
            };
        /*----------------------------------------------------------------------*/
        // Get All Employees
        // http://http://localhost:5298/Employee/GetAll
        public IActionResult GetAll()
        {
            // View Bag to Pass data from controller to view
            ViewBag.Employees = _Employees;
            return View();
        }
        /*----------------------------------------------------------------------*/
        // Get one By Id
        public IActionResult ViewDetails(int id)
        {
            var emp = _Employees.FirstOrDefault(e => e.Id == id);
            ViewBag.SingleEmp = emp;
            return View();
        }
        /*----------------------------------------------------------------------*/
        // Return Create View
        public IActionResult Create()
        {
            return View();
        }
        /*----------------------------------------------------------------------*/
        // Actual Create New Employee
        public IActionResult ActualCreate(int id, string name, int age, decimal salary)
        {
            Employee newEmp = new Employee { Id = id, Name = name, Age = age, Salary= salary };
            _Employees.Add(newEmp); // Employee Obj To insert into List
            return RedirectToAction("GetAll");
        }
        /*----------------------------------------------------------------------*/
    }
}

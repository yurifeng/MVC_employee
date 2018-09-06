using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GetView
        /// </summary>
        /// <returns></returns>
        //public ViewResult GetView()
        //{
        //    Employee em = new Employee()
        //    {
        //        FirstName = "yuri",
        //        LastName = "feng",
        //        Salary = 20000,
        //    };
        //    ViewData["Employee"] = em;
        //    return View("getview");
        //}

        /// <summary>
        /// GetViews
        /// 使用了ViewModels
        /// </summary>
        /// <returns></returns>
        //public ActionResult GetViews()
        //{
        //    Employee emp = new Employee
        //    {
        //        FirstName = "alan",
        //        LastName = "gustov",
        //        Salary = 25000
        //    };

        //    EmployeeViewModel evm = new EmployeeViewModel
        //    {
        //        EmployeeName = emp.FirstName + " " + emp.LastName,
        //        Salary = emp.Salary.ToString("c")
        //    };
        //    if (emp.Salary < 15000)
        //    {
        //        evm.SalaryColor = "yellow";
        //    }
        //    else
        //    {
        //        evm.SalaryColor = "green";
        //    }

        //    evm.UserName = "admin";
        //    return View("GetView", evm);
        //}

        public ActionResult GetViewPage()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.GetEmployees();
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            foreach (Employee employee in employees)
            {
                EmployeeViewModel employeeViewModel =
                    new EmployeeViewModel
                    {
                        EmployeeName = employee.FirstName + " " + employee.LastName,
                        Salary = employee.Salary.ToString("C")
                    };
                if (employee.Salary > 15000)
                {
                    employeeViewModel.SalaryColor = "yellow";
                }
                else
                {
                    employeeViewModel.SalaryColor = "green";
                }
                employeeViewModels.Add(employeeViewModel);
            }

            employeeListViewModel.Employees = employeeViewModels;
            employeeListViewModel.UserName = "admin";
            return View("GetView", employeeListViewModel);

        }

    }
}
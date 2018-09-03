using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;

namespace WebApplication1.Models
{
    /// <summary>
    /// 业务层
    /// </summary>
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            #region 硬编码添加Employee

            //List<Employee> employees = new List<Employee>();
            //Employee emp = new Employee()
            //{
            //    FirstName = "alan",
            //    LastName = "gustov",
            //    Salary = 15000,
            //};
            //employees.Add(emp);

            //emp = new Employee()
            //{
            //    FirstName = "micheal",
            //    LastName = "jackson",
            //    Salary = 20000,
            //};
            //employees.Add(emp);

            //emp = new Employee()
            //{
            //    FirstName = "paul",
            //    LastName = "walker",
            //    Salary = 46000,
            //};
            //employees.Add(emp);

            //return employees;

            #endregion

            #region 从数据库中查询employee

            dbtest dbtest = new dbtest();
            return dbtest.Employees.ToList();

            #endregion
        }
    }
}
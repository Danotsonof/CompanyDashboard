using Company.Data;
using Company.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.DBOperations.Repository
{
    public class EmployeeOperations : IEmployeeOp
    {
        /// <summary>
        /// Global variable, instantiating the Context connection.
        /// </summary>
        private CompanyContext _companyContext = new CompanyContext();
        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>returns true if successful, else false</returns>
        public bool Add(Employee employee)
        {
            try
            {
                using (var companyContext = new CompanyContext())
                {
                    companyContext.Employees.Add(employee);
                    companyContext.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }            
        }
        /// <summary>
        /// Deletes an employee from the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>true if successful, else false</returns>
        public bool Delete(Employee employee)
        {
            try
            {
                using (var companyContext = new CompanyContext())
                {
                    companyContext.Employees.Remove(employee);
                    companyContext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        /// <summary>
        /// A query method that filters the database based on a salary(150000) threshold
        /// </summary>
        /// <returns>the data with salary above 150000</returns>
        public IEnumerable FilterBySalary()
        {
            using (var companyContext = new CompanyContext())
            {
                var filtered = _companyContext.Employees
                .Where(e => e.SALARY > 150000)
                .Include(d => d.Departments)
                .Select(e => new {
                    e.EMPLOYEEID,
                    e.FIRST_NAME,
                    e.LAST_NAME,
                    e.EMAIL,
                    e.PHONE_NUMBER,
                    e.HIRE_DATE,
                    e.SALARY,
                    e.Departments.DEPARTMENT_NAME,
                    e.Departments.DEPARTMENTID
                })
                .ToList();

                return filtered;
            }
        }
        /// <summary>
        /// Queries the database and gets all employee records 
        /// that has a department
        /// </summary>
        /// <returns>an enumerable containing database data</returns>
        public IEnumerable GetAllButNull()
        {
            var allEmployees = _companyContext.Employees
                .Where(w => !string.IsNullOrEmpty(w.DEPARTMENTID.ToString()))
                .Include(d => d.Departments)
                .Select(e => new {
                    e.EMPLOYEEID,
                    e.FIRST_NAME,
                    e.LAST_NAME,
                    e.EMAIL,
                    e.PHONE_NUMBER,
                    e.HIRE_DATE,
                    e.SALARY,
                    e.Departments.DEPARTMENT_NAME,
                    e.Departments.DEPARTMENTID
                })
                .ToList();

            return allEmployees;
        }
        /// <summary>
        /// Queries the database and gets all employee records 
        /// with or without a department
        /// </summary>
        /// <returns>an enumerable containing database data</returns>
        public IEnumerable GetAll()
        {
            var allEmployees = _companyContext.Employees
                .Include(d => d.Departments)
                .Select(e => new {
                    e.EMPLOYEEID,
                    e.FIRST_NAME,
                    e.LAST_NAME,
                    e.EMAIL,
                    e.PHONE_NUMBER,
                    e.HIRE_DATE,
                    e.SALARY,
                    e.Departments.DEPARTMENT_NAME,
                    e.Departments.DEPARTMENTID
                })
                .ToList();

            return allEmployees;
        }
        /// <summary>
        /// Updates the employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>true if successful, else false</returns>
        public bool Update(Employee employee)
        {
            try
            {
                if (employee.Departments.DEPARTMENTID == -1)
                {
                    var d = _companyContext.Departments
                        .Where(e => e.DEPARTMENT_NAME == employee.Departments.DEPARTMENT_NAME)
                        .FirstOrDefault();
                    employee.Departments = d;
                }

                using (var companyContext = new CompanyContext())
                {
                    companyContext.Employees.Update(employee);
                    companyContext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

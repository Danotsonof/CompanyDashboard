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
    public class DepartmentOperations : IDepartmentOp
    {
        /// <summary>
        /// Global variable, instantiating the Context connection.
        /// </summary>
        private CompanyContext _companyContext = new CompanyContext();
        /// <summary>
        /// Adds new department
        /// </summary>
        /// <param name="department"></param>
        /// <returns>returns true if successful else false</returns>
        public bool Add(string department)
        {
            var dept = _companyContext.Departments.Where(d => d.DEPARTMENT_NAME == department.ToLower()).FirstOrDefault();

            if (dept != null) return false;

            using (var companyContext = new CompanyContext())
            {
                companyContext.Departments.Add(new Department
                {
                    DEPARTMENT_NAME = department.ToLower()
                });
                companyContext.SaveChanges();
            }

            return true;
        }
        /// <summary>
        //// Deletes a department from the database
        /// </summary>
        /// <param name="department"></param>
        public void Delete(Department department)
        {
            using (var companyContext = new CompanyContext())
            {
                companyContext.Departments.Remove(department);
                companyContext.SaveChanges();
            }
        }
        /// <summary>
        /// Gets the departments with unassigned employee
        /// </summary>
        /// <returns>returns a list of department names</returns>
        public IEnumerable DeptWithoutEmployees()
        {
            List<string> allEmployees = _companyContext.Employees
                .Where(w => !string.IsNullOrEmpty(w.Departments.DEPARTMENT_NAME))
                .Select(e => e.Departments.DEPARTMENT_NAME)
                .ToList();
            var dept = _companyContext.Departments
                .Where(d => !allEmployees.Contains(d.DEPARTMENT_NAME))
                //.Select(d => d.DEPARTMENT_NAME)
                .Select(s => new { Department = s.DEPARTMENT_NAME })
                .ToList();
            return dept;
        }
        /// <summary>
        /// Gets all the departments in the database
        /// </summary>
        /// <returns>list of departments</returns>
        public List<string> GetAll()
        {
            var allDepts = _companyContext.Departments
                .Select(d => d.DEPARTMENT_NAME)
                .ToList();

            return allDepts;
        }
        /// <summary>
        /// Gets the department object of a passed in department string
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        public Department GetDepartment(string deptName)
        {
            var dept = _companyContext.Departments
                .Where(d => d.DEPARTMENT_NAME == deptName)
                .FirstOrDefault();

            return dept;
        }
        /// <summary>
        /// Groups the employee by their department in ascending order
        /// </summary>
        /// <returns>an enumerable of the requested data</returns>
        public IEnumerable GroupDB()
        {
            var allEmployees = _companyContext.Employees
                .Include(d => d.Departments)
                .Where(w => !string.IsNullOrEmpty(w.DEPARTMENTID.ToString()))
                .OrderBy(o => o.Departments.DEPARTMENT_NAME)
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
        /// Updates the department passed in
        /// </summary>
        /// <param name="department"></param>
        public void Update(Department department)
        {
            using (var companyContext = new CompanyContext())
            {
                companyContext.Departments.Update(department);
                companyContext.SaveChanges();
            }
        }
    }
}

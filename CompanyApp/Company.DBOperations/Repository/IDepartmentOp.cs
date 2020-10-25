using Company.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Company.DBOperations.Repository
{
    public interface IDepartmentOp
    {
        /// <summary>
        /// Groups the employee by their department in ascending order
        /// </summary>
        /// <returns>an enumerable of the requested data</returns>
        IEnumerable GroupDB();
        /// <summary>
        /// Gets all the departments in the database
        /// </summary>
        /// <returns>list of departments</returns>
        List<string> GetAll();
        /// <summary>
        /// Gets the departments with unassigned employee
        /// </summary>
        /// <returns>returns a list of department names</returns>
        IEnumerable DeptWithoutEmployees();
        /// <summary>
        /// Adds new department
        /// </summary>
        /// <param name="department"></param>
        /// <returns>returns true if successful else false</returns>
        bool Add(string department);
        /// <summary>
        /// Updates the department passed in
        /// </summary>
        /// <param name="department"></param>
        void Update(Department department);
        /// <summary>
        //// Deletes a department from the database
        /// </summary>
        /// <param name="department"></param>
        void Delete(Department department);
        /// <summary>
        /// Gets the department object of a passed in department string
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        Department GetDepartment(string deptName);
    }
}

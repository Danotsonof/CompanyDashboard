using Company.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Company.DBOperations.Repository
{
    public interface IEmployeeOp
    {
        /// <summary>
        /// Queries the database and gets all employee records 
        /// that has a department
        /// </summary>
        /// <returns>an enumerable containing database data</returns>
        IEnumerable GetAllButNull();
        /// <summary>
        /// Queries the database and gets all employee records 
        /// with or without a department
        /// </summary>
        /// <returns>an enumerable containing database data</returns>
        IEnumerable GetAll();
        /// <summary>
        /// A query method that filters the database based on a salary(150000) threshold
        /// </summary>
        /// <returns>the data with salary above 150000</returns>
        IEnumerable FilterBySalary();
        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>returns true if successful, else false</returns>
        bool Add(Employee employee);
        /// <summary>
        /// Updates the employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>true if successful, else false</returns>
        bool Update(Employee employee);
        /// <summary>
        /// Deletes an employee from the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>true if successful, else false</returns>
        bool Delete(Employee employee);
    }
}

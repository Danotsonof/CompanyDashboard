using System;

namespace Company.Domain
{
    /// <summary>
    /// Employee entity; Domain class model.
    /// this defines the schema for the table to be created
    /// </summary>
    public class Employee
    {
        public int EMPLOYEEID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public DateTime HIRE_DATE { get; set; }
        public double SALARY { get; set; }
        public int? DEPARTMENTID { get; set; }
        public Department Departments { get; set; }
    }
}

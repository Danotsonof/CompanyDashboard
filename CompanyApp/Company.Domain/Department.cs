using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Domain
{
    /// <summary>
    /// Department entity; Domain class model.
    /// this defines the schema for the table to be created
    /// </summary>
    public class Department
    {
        public int DEPARTMENTID { get; set; }
        public string DEPARTMENT_NAME { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

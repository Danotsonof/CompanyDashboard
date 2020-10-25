using Company.Data;
using Company.DBOperations.Repository;
using System;

namespace Company.DBOperations
{
    /// <summary>
    /// Configuring the injection of methods
    /// </summary>
    public static class GlobalConfig
    {
        public static IEmployeeOp EmployeeInstance { get; private set; }
        public static IDepartmentOp DepartmentInstance { get; private set; }
        public static void AddInstance()
        {
            EmployeeInstance = new EmployeeOperations();
            DepartmentInstance = new DepartmentOperations();
        }
    }
}

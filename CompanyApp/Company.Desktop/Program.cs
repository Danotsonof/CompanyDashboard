using Company.DBOperations;
using Company.DBOperations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.Desktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.AddInstance();
            IEmployeeOp employeeOps = GlobalConfig.EmployeeInstance;
            IDepartmentOp departmentOps = GlobalConfig.DepartmentInstance;
            Application.Run(new Homepage(employeeOps, departmentOps));
        }
    }
}

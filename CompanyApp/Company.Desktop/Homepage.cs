using Company.DBOperations.Repository;
using Company.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.Desktop
{
    public partial class Homepage : Form
    {
        /// <summary>
        /// Global Variables
        /// </summary>
        public static int EMP_ID { get; set; }
        public static Department DEPT { get; set; } = new Department();
        public static bool deptModSelected { get; set; }
        public static bool deptUpdSelected { get; set; }
        public static bool empSelected { get; set; }
        public static Department MODIFYINGDEPT { get; set; }
        private readonly IEmployeeOp EmployeeOp;
        private readonly IDepartmentOp DepartmentOp;

        /// <summary>
        /// Constructor for the Homepage class
        /// </summary>
        /// <param name="employeeOp"></param>
        /// <param name="departmentOp"></param>
        public Homepage(IEmployeeOp employeeOp, IDepartmentOp departmentOp)
        {
            InitializeComponent();
            this.EmployeeOp = employeeOp;
            this.DepartmentOp = departmentOp;
        }
        /// <summary>
        /// Retrieves the employee and departs data from the database once this forms loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Homepage_Load(object sender, EventArgs e)
        {
            // Loads employee data into datagrid
            EmployeesDGView.DataSource = EmployeeOp.GetAllButNull();
            // Loads departments into the comboboxs
            DepartmentCBox.Items.Clear();
            ModifyDeptCBox.Items.Clear();
            foreach (var item in DepartmentOp.GetAll())
            {
                DepartmentCBox.Items.Add(item);
                ModifyDeptCBox.Items.Add(item);
            }
            displayEmpWithDeptRBtn.PerformClick();
        }
        /// <summary>
        /// Clears the texts in the textbox fields
        /// </summary>
        private void ClearTextBoxes()
        {
            firstNameTBox.Clear();
            lastNameTBox.Clear();
            emailTBox.Clear();
            phoneNumberTBox.Clear();
            hiredDateTPicker.Value = DateTime.Parse("01/01/2020");
            salaryTBox.Clear();
            DepartmentCBox.Items.Clear();
            ModifyDeptCBox.Items.Clear();
            foreach (var item in DepartmentOp.GetAll())
            {
                DepartmentCBox.Items.Add(item);
                ModifyDeptCBox.Items.Add(item);
            }
        }
        /// <summary>
        /// Retrieves employees details from the selected row of the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeesDGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deptWithoutEmployee.Checked)
            {
                MessageBox.Show("Click on another operation and select an employee data.");
            }
            else if (EmployeesDGView.SelectedRows.Count > 0 || EmployeesDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                empSelected = true;
                this.EmployeesDGView.Columns[0].Visible = false;
                EMP_ID = int.Parse(EmployeesDGView.Rows[e.RowIndex].Cells["EMPLOYEEID"].FormattedValue.ToString());
                firstNameTBox.Text = EmployeesDGView.Rows[e.RowIndex].Cells["FIRST_NAME"].FormattedValue.ToString();
                lastNameTBox.Text = EmployeesDGView.Rows[e.RowIndex].Cells["LAST_NAME"].FormattedValue.ToString();
                emailTBox.Text = EmployeesDGView.Rows[e.RowIndex].Cells["EMAIL"].FormattedValue.ToString();
                phoneNumberTBox.Text = EmployeesDGView.Rows[e.RowIndex].Cells["PHONE_NUMBER"].FormattedValue.ToString();
                hiredDateTPicker.Value = DateTime.Parse(EmployeesDGView.Rows[e.RowIndex].Cells["HIRE_DATE"].FormattedValue.ToString());
                salaryTBox.Text = EmployeesDGView.Rows[e.RowIndex].Cells["SALARY"].FormattedValue.ToString();

                DEPT.DEPARTMENTID = int.Parse(EmployeesDGView.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString());
                DEPT.DEPARTMENT_NAME = EmployeesDGView.Rows[e.RowIndex].Cells["DEPARTMENT_NAME"].FormattedValue.ToString();
                if (DEPT.DEPARTMENT_NAME == "")
                {
                    DepartmentCBox.Items.Clear();
                    ModifyDeptCBox.Items.Clear();
                    foreach (var item in DepartmentOp.GetAll())
                    {
                        DepartmentCBox.Items.Add(item);
                        ModifyDeptCBox.Items.Add(item);
                    }
                }
                else
                {
                    DepartmentCBox.SelectedItem = DEPT.DEPARTMENT_NAME;
                }
            }
            else
            {
                MessageBox.Show("Click on a cell with data to select an employee.");
            }
        }
        /// <summary>
        /// Monitors when a department is selected from the combo box
        /// attached to the employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieves the department object of selected the department
            DEPT = DepartmentOp.GetDepartment(DepartmentCBox.SelectedItem.ToString());
            deptUpdSelected = true;
        }
        /// <summary>
        /// Button click function to add an employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            // store the values of the text box
            var fn = firstNameTBox.Text;
            var ln = lastNameTBox.Text;
            var email = emailTBox.Text;
            var pn = phoneNumberTBox.Text;
            var hd = hiredDateTPicker.Value;
            var s = salaryTBox.Text;
            // check if any field has wrong input format
            if (!string.IsNullOrEmpty(fn)
             && !string.IsNullOrEmpty(ln)
             && !string.IsNullOrEmpty(email)
             && long.TryParse(pn, out long num)
             && double.TryParse(s, out double salary))
            {
                Employee em = new Employee {
                    FIRST_NAME = fn,
                    LAST_NAME = ln,
                    EMAIL = email,
                    PHONE_NUMBER = num.ToString(),
                    HIRE_DATE = hd,
                    SALARY = salary
                };

                if (!string.IsNullOrEmpty(DepartmentCBox.Text))
                {
                    em.DEPARTMENTID = DepartmentOp.GetDepartment(DepartmentCBox.Text).DEPARTMENTID;
                }
                // adds new employee         
                if (EmployeeOp.Add(em))
                {
                    //EmployeesDGView.DataSource = EmployeeOp.GetAllButNull();

                    displayEmpWithDeptRBtn.Checked = true;
                    MessageBox.Show("Employee added successfully.");
                    ClearTextBoxes();
                    deptUpdSelected = false;
                }
                else
                {
                    MessageBox.Show("Error occured. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Input all valid data.");
            }
        }
        /// <summary>
        /// Button click function to delete an employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            // store the values of the text box
            var fn = firstNameTBox.Text;
            var ln = lastNameTBox.Text;
            var email = emailTBox.Text;
            var pn = phoneNumberTBox.Text;
            var hd = hiredDateTPicker.Value;
            var s = salaryTBox.Text;

            if (!string.IsNullOrEmpty(fn)
             && !string.IsNullOrEmpty(ln)
             && !string.IsNullOrEmpty(email)
             && !string.IsNullOrEmpty(pn)
             && !string.IsNullOrEmpty(s)
             && empSelected)
            {
                Employee em = new Employee
                {
                    EMPLOYEEID = EMP_ID,
                    FIRST_NAME = fn,
                    LAST_NAME = ln,
                    EMAIL = email,
                    PHONE_NUMBER = pn,
                    HIRE_DATE = hd,
                    SALARY = double.Parse(s)
                };

                if (EmployeeOp.Delete(em))
                {
                    EmployeesDGView.DataSource = EmployeeOp.GetAllButNull();

                    MessageBox.Show("Employee deleted successfully.");
                    ClearTextBoxes();
                    empSelected = false;
                }
                else
                {
                    MessageBox.Show("Error occured. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Select an employee and input valid data.");
            }
        }
        /// <summary>
        /// Button click function to update an employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateEmpBtn_Click(object sender, EventArgs e)
        {
            var fn = firstNameTBox.Text;
            var ln = lastNameTBox.Text;
            var email = emailTBox.Text;
            var pn = phoneNumberTBox.Text;
            var hd = hiredDateTPicker.Value;
            var s = salaryTBox.Text;

            if (!string.IsNullOrEmpty(fn)
             && !string.IsNullOrEmpty(ln)
             && !string.IsNullOrEmpty(email)
             && long.TryParse(pn, out long num)
             && double.TryParse(s, out double salary)
             && empSelected)
            {
                Employee em = new Employee
                {
                    EMPLOYEEID = EMP_ID,
                    FIRST_NAME = fn,
                    LAST_NAME = ln,
                    EMAIL = email,
                    PHONE_NUMBER = num.ToString(),
                    HIRE_DATE = hd,
                    SALARY = salary,
                    Departments = deptUpdSelected ? new Department { 
                        DEPARTMENTID = -1,
                        DEPARTMENT_NAME = DepartmentCBox.Text } : DEPT
                };

                if (EmployeeOp.Update(em))
                {
                    EmployeesDGView.DataSource = EmployeeOp.GetAllButNull();

                    MessageBox.Show("Employee updated successfully.");
                    ClearTextBoxes();
                    empSelected = false;
                    deptUpdSelected = false;
                    DEPT = null;
                }
                else
                {
                    MessageBox.Show("Error occured. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Select an employee and input valid data.");
            }
        }
        /// <summary>
        /// Monitors when a department is selected from the combo box
        /// attached to the department
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyDeptCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDeptTBox.Text = ModifyDeptCBox.Text;
            deptModSelected = true;
            MODIFYINGDEPT = DepartmentOp.GetDepartment(updateDeptTBox.Text);
        }
        /// <summary>
        /// Button for deleting a department
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteDeptBtn_Click(object sender, EventArgs e)
        {
            if (deptModSelected)
            {
                DepartmentOp.Delete(MODIFYINGDEPT);
                updateDeptTBox.Clear();
                displayEmpWithDeptRBtn.Checked = true;
                //EmployeesDGView.DataSource = EmployeeOp.GetAllButNull();
                deptModSelected = false;
                DepartmentCBox.Items.Clear();
                ModifyDeptCBox.Items.Clear();
                foreach (var item in DepartmentOp.GetAll())
                {
                    DepartmentCBox.Items.Add(item);
                    ModifyDeptCBox.Items.Add(item);
                }
                MessageBox.Show("Department deleted successfully.");
            }
            else
            {
                MessageBox.Show("Select a department from the dropdown.");
            }
        }
        /// <summary>
        /// Button for updating a department
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateDeptBtn_Click(object sender, EventArgs e)
        {
            if (deptModSelected && !string.IsNullOrEmpty(updateDeptTBox.Text) && !string.IsNullOrWhiteSpace(updateDeptTBox.Text))
            {
                DepartmentOp.Update(new Department
                {
                    DEPARTMENTID = MODIFYINGDEPT.DEPARTMENTID,
                    DEPARTMENT_NAME = updateDeptTBox.Text.ToLower()
                });
                DepartmentCBox.Items.Clear();
                ModifyDeptCBox.Items.Clear();
                foreach (var item in DepartmentOp.GetAll())
                {
                    DepartmentCBox.Items.Add(item);
                    ModifyDeptCBox.Items.Add(item);
                }
                updateDeptTBox.Clear();
                MessageBox.Show("Department updated successfully.");
                deptModSelected = false;
            }
            else
            {
                MessageBox.Show("Input a valid data.");
            }
        }
        /// <summary>
        /// Button to add a new department
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDeptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addDeptTBox.Text) && !string.IsNullOrWhiteSpace(addDeptTBox.Text))
            {
                if (DepartmentOp.Add(addDeptTBox.Text))
                {
                    DepartmentCBox.Items.Clear();
                    ModifyDeptCBox.Items.Clear();
                    foreach (var item in DepartmentOp.GetAll())
                    {
                        DepartmentCBox.Items.Add(item);
                        ModifyDeptCBox.Items.Add(item);
                    }
                    addDeptTBox.Text = string.Empty;
                    MessageBox.Show("Department added successfully.");
                }
                else
                {
                    MessageBox.Show("Department already exists.");
                }
            }
            else
            {
                MessageBox.Show("Kindly input a department name.");
            }
        }
        /// <summary>
        /// Radio button to display employees in departments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayEmpWithDeptRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            EmployeesDGView.DataSource = EmployeeOp.GetAllButNull();
            EmployeesDGView.Columns[0].Visible = false;
            EmployeesDGView.Columns[8].Visible = false;
        }
        /// <summary>
        /// Radio button to group employees in department by their departments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupByDeptRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            EmployeesDGView.DataSource = DepartmentOp.GroupDB();
            EmployeesDGView.Columns[0].Visible = false;
            EmployeesDGView.Columns[8].Visible = false;
        }
        /// <summary>
        /// Radio button to filter employees result by a salary threshhold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryFilterRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            EmployeesDGView.DataSource = EmployeeOp.FilterBySalary();
            EmployeesDGView.Columns[0].Visible = false;
            EmployeesDGView.Columns[8].Visible = false;
        }
        /// <summary>
        /// Radio button to display departments with no employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deptWithoutEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            EmployeesDGView.DataSource = DepartmentOp.DeptWithoutEmployees();
        }
        /// <summary>
        /// Radio button Displays all employees data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            EmployeesDGView.DataSource = EmployeeOp.GetAll();
            EmployeesDGView.Columns[0].Visible = false;
            EmployeesDGView.Columns[8].Visible = false;
        }
    }
}

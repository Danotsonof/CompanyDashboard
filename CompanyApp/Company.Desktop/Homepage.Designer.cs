namespace Company.Desktop
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DepartmentCBox = new System.Windows.Forms.ComboBox();
            this.addDeptBtn = new System.Windows.Forms.Button();
            this.modifyDeptGBox = new System.Windows.Forms.GroupBox();
            this.updateDeptTBox = new System.Windows.Forms.TextBox();
            this.updateDeptBtn = new System.Windows.Forms.Button();
            this.deleteDeptBtn = new System.Windows.Forms.Button();
            this.ModifyDeptCBox = new System.Windows.Forms.ComboBox();
            this.deptName = new System.Windows.Forms.Label();
            this.addDeptTBox = new System.Windows.Forms.TextBox();
            this.selectDept = new System.Windows.Forms.Label();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastNameTBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.phoneNumberTBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.emailTBox = new System.Windows.Forms.TextBox();
            this.salaryTBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.employeeDetailsGBox = new System.Windows.Forms.GroupBox();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.updateEmpBtn = new System.Windows.Forms.Button();
            this.deleteEmpBtn = new System.Windows.Forms.Button();
            this.hiredDate = new System.Windows.Forms.Label();
            this.hiredDateTPicker = new System.Windows.Forms.DateTimePicker();
            this.displayEmpWithDeptRBtn = new System.Windows.Forms.RadioButton();
            this.groupByDeptRBtn = new System.Windows.Forms.RadioButton();
            this.salaryFilterRBtn = new System.Windows.Forms.RadioButton();
            this.deptWithoutEmployee = new System.Windows.Forms.RadioButton();
            this.displayAllBtn = new System.Windows.Forms.RadioButton();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesDGView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Queries = new System.Windows.Forms.GroupBox();
            this.modifyDeptGBox.SuspendLayout();
            this.employeeDetailsGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGView)).BeginInit();
            this.Queries.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentCBox
            // 
            this.DepartmentCBox.DisplayMember = "Deo";
            this.DepartmentCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentCBox.FormattingEnabled = true;
            this.DepartmentCBox.Location = new System.Drawing.Point(135, 293);
            this.DepartmentCBox.MaxDropDownItems = 50;
            this.DepartmentCBox.Name = "DepartmentCBox";
            this.DepartmentCBox.Size = new System.Drawing.Size(157, 23);
            this.DepartmentCBox.TabIndex = 0;
            this.DepartmentCBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentCBox_SelectedIndexChanged);
            // 
            // addDeptBtn
            // 
            this.addDeptBtn.Location = new System.Drawing.Point(228, 182);
            this.addDeptBtn.Name = "addDeptBtn";
            this.addDeptBtn.Size = new System.Drawing.Size(117, 26);
            this.addDeptBtn.TabIndex = 2;
            this.addDeptBtn.Text = "Add Department";
            this.addDeptBtn.UseVisualStyleBackColor = true;
            this.addDeptBtn.Click += new System.EventHandler(this.addDeptBtn_Click);
            // 
            // modifyDeptGBox
            // 
            this.modifyDeptGBox.Controls.Add(this.updateDeptTBox);
            this.modifyDeptGBox.Controls.Add(this.updateDeptBtn);
            this.modifyDeptGBox.Controls.Add(this.deleteDeptBtn);
            this.modifyDeptGBox.Controls.Add(this.ModifyDeptCBox);
            this.modifyDeptGBox.Controls.Add(this.deptName);
            this.modifyDeptGBox.Controls.Add(this.addDeptTBox);
            this.modifyDeptGBox.Controls.Add(this.addDeptBtn);
            this.modifyDeptGBox.Location = new System.Drawing.Point(629, 452);
            this.modifyDeptGBox.Name = "modifyDeptGBox";
            this.modifyDeptGBox.Size = new System.Drawing.Size(387, 241);
            this.modifyDeptGBox.TabIndex = 3;
            this.modifyDeptGBox.TabStop = false;
            this.modifyDeptGBox.Text = "Modify Department";
            // 
            // updateDeptTBox
            // 
            this.updateDeptTBox.Location = new System.Drawing.Point(216, 59);
            this.updateDeptTBox.Name = "updateDeptTBox";
            this.updateDeptTBox.Size = new System.Drawing.Size(132, 23);
            this.updateDeptTBox.TabIndex = 7;
            // 
            // updateDeptBtn
            // 
            this.updateDeptBtn.Location = new System.Drawing.Point(226, 98);
            this.updateDeptBtn.Name = "updateDeptBtn";
            this.updateDeptBtn.Size = new System.Drawing.Size(122, 30);
            this.updateDeptBtn.TabIndex = 6;
            this.updateDeptBtn.Text = "Update Department";
            this.updateDeptBtn.UseVisualStyleBackColor = true;
            this.updateDeptBtn.Click += new System.EventHandler(this.updateDeptBtn_Click);
            // 
            // deleteDeptBtn
            // 
            this.deleteDeptBtn.Location = new System.Drawing.Point(23, 98);
            this.deleteDeptBtn.Name = "deleteDeptBtn";
            this.deleteDeptBtn.Size = new System.Drawing.Size(122, 30);
            this.deleteDeptBtn.TabIndex = 6;
            this.deleteDeptBtn.Text = "Delete Department";
            this.deleteDeptBtn.UseVisualStyleBackColor = true;
            this.deleteDeptBtn.Click += new System.EventHandler(this.deleteDeptBtn_Click);
            // 
            // ModifyDeptCBox
            // 
            this.ModifyDeptCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifyDeptCBox.FormattingEnabled = true;
            this.ModifyDeptCBox.Location = new System.Drawing.Point(23, 59);
            this.ModifyDeptCBox.Name = "ModifyDeptCBox";
            this.ModifyDeptCBox.Size = new System.Drawing.Size(150, 23);
            this.ModifyDeptCBox.TabIndex = 5;
            this.ModifyDeptCBox.SelectedIndexChanged += new System.EventHandler(this.ModifyDeptCBox_SelectedIndexChanged);
            // 
            // deptName
            // 
            this.deptName.AutoSize = true;
            this.deptName.Location = new System.Drawing.Point(23, 30);
            this.deptName.Name = "deptName";
            this.deptName.Size = new System.Drawing.Size(105, 15);
            this.deptName.TabIndex = 4;
            this.deptName.Text = "Department Name";
            // 
            // addDeptTBox
            // 
            this.addDeptTBox.Location = new System.Drawing.Point(23, 182);
            this.addDeptTBox.Name = "addDeptTBox";
            this.addDeptTBox.Size = new System.Drawing.Size(156, 23);
            this.addDeptTBox.TabIndex = 3;
            // 
            // selectDept
            // 
            this.selectDept.AutoSize = true;
            this.selectDept.Location = new System.Drawing.Point(22, 296);
            this.selectDept.Name = "selectDept";
            this.selectDept.Size = new System.Drawing.Size(104, 15);
            this.selectDept.TabIndex = 4;
            this.selectDept.Text = "Select Department";
            // 
            // firstNameTBox
            // 
            this.firstNameTBox.Location = new System.Drawing.Point(135, 29);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(156, 23);
            this.firstNameTBox.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(21, 32);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(64, 15);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "First Name";
            // 
            // lastNameTBox
            // 
            this.lastNameTBox.Location = new System.Drawing.Point(135, 75);
            this.lastNameTBox.Name = "lastNameTBox";
            this.lastNameTBox.Size = new System.Drawing.Size(156, 23);
            this.lastNameTBox.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(21, 75);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(63, 15);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last Name";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(21, 169);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(88, 15);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "Phone Number";
            // 
            // phoneNumberTBox
            // 
            this.phoneNumberTBox.Location = new System.Drawing.Point(135, 169);
            this.phoneNumberTBox.Name = "phoneNumberTBox";
            this.phoneNumberTBox.Size = new System.Drawing.Size(156, 23);
            this.phoneNumberTBox.TabIndex = 3;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(21, 126);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(81, 15);
            this.email.TabIndex = 4;
            this.email.Text = "Email Address";
            // 
            // emailTBox
            // 
            this.emailTBox.Location = new System.Drawing.Point(135, 123);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.Size = new System.Drawing.Size(156, 23);
            this.emailTBox.TabIndex = 3;
            // 
            // salaryTBox
            // 
            this.salaryTBox.Location = new System.Drawing.Point(135, 255);
            this.salaryTBox.Name = "salaryTBox";
            this.salaryTBox.Size = new System.Drawing.Size(157, 23);
            this.salaryTBox.TabIndex = 3;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(22, 255);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(38, 15);
            this.salary.TabIndex = 4;
            this.salary.Text = "Salary";
            // 
            // employeeDetailsGBox
            // 
            this.employeeDetailsGBox.Controls.Add(this.addEmpBtn);
            this.employeeDetailsGBox.Controls.Add(this.updateEmpBtn);
            this.employeeDetailsGBox.Controls.Add(this.deleteEmpBtn);
            this.employeeDetailsGBox.Controls.Add(this.hiredDate);
            this.employeeDetailsGBox.Controls.Add(this.selectDept);
            this.employeeDetailsGBox.Controls.Add(this.hiredDateTPicker);
            this.employeeDetailsGBox.Controls.Add(this.salary);
            this.employeeDetailsGBox.Controls.Add(this.DepartmentCBox);
            this.employeeDetailsGBox.Controls.Add(this.salaryTBox);
            this.employeeDetailsGBox.Controls.Add(this.emailTBox);
            this.employeeDetailsGBox.Controls.Add(this.email);
            this.employeeDetailsGBox.Controls.Add(this.phoneNumberTBox);
            this.employeeDetailsGBox.Controls.Add(this.phoneNumber);
            this.employeeDetailsGBox.Controls.Add(this.lastName);
            this.employeeDetailsGBox.Controls.Add(this.lastNameTBox);
            this.employeeDetailsGBox.Controls.Add(this.firstName);
            this.employeeDetailsGBox.Controls.Add(this.firstNameTBox);
            this.employeeDetailsGBox.Location = new System.Drawing.Point(61, 415);
            this.employeeDetailsGBox.Name = "employeeDetailsGBox";
            this.employeeDetailsGBox.Size = new System.Drawing.Size(515, 332);
            this.employeeDetailsGBox.TabIndex = 5;
            this.employeeDetailsGBox.TabStop = false;
            this.employeeDetailsGBox.Text = "Employee Details";
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(374, 75);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(94, 31);
            this.addEmpBtn.TabIndex = 7;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // updateEmpBtn
            // 
            this.updateEmpBtn.Location = new System.Drawing.Point(369, 230);
            this.updateEmpBtn.Name = "updateEmpBtn";
            this.updateEmpBtn.Size = new System.Drawing.Size(108, 31);
            this.updateEmpBtn.TabIndex = 7;
            this.updateEmpBtn.Text = "Update Employee";
            this.updateEmpBtn.UseVisualStyleBackColor = true;
            this.updateEmpBtn.Click += new System.EventHandler(this.updateEmpBtn_Click);
            // 
            // deleteEmpBtn
            // 
            this.deleteEmpBtn.Location = new System.Drawing.Point(374, 161);
            this.deleteEmpBtn.Name = "deleteEmpBtn";
            this.deleteEmpBtn.Size = new System.Drawing.Size(103, 31);
            this.deleteEmpBtn.TabIndex = 7;
            this.deleteEmpBtn.Text = "Delete Employee";
            this.deleteEmpBtn.UseVisualStyleBackColor = true;
            this.deleteEmpBtn.Click += new System.EventHandler(this.deleteEmpBtn_Click);
            // 
            // hiredDate
            // 
            this.hiredDate.AutoSize = true;
            this.hiredDate.Location = new System.Drawing.Point(22, 220);
            this.hiredDate.Name = "hiredDate";
            this.hiredDate.Size = new System.Drawing.Size(63, 15);
            this.hiredDate.TabIndex = 4;
            this.hiredDate.Text = "Hired Date";
            // 
            // hiredDateTPicker
            // 
            this.hiredDateTPicker.Location = new System.Drawing.Point(135, 214);
            this.hiredDateTPicker.Name = "hiredDateTPicker";
            this.hiredDateTPicker.Size = new System.Drawing.Size(156, 23);
            this.hiredDateTPicker.TabIndex = 5;
            this.hiredDateTPicker.Value = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            // 
            // displayEmpWithDeptRBtn
            // 
            this.displayEmpWithDeptRBtn.AutoSize = true;
            this.displayEmpWithDeptRBtn.Location = new System.Drawing.Point(12, 38);
            this.displayEmpWithDeptRBtn.Name = "displayEmpWithDeptRBtn";
            this.displayEmpWithDeptRBtn.Size = new System.Drawing.Size(210, 19);
            this.displayEmpWithDeptRBtn.TabIndex = 6;
            this.displayEmpWithDeptRBtn.TabStop = true;
            this.displayEmpWithDeptRBtn.Text = "Employees With Their Departments";
            this.displayEmpWithDeptRBtn.UseVisualStyleBackColor = true;
            this.displayEmpWithDeptRBtn.CheckedChanged += new System.EventHandler(this.displayEmpWithDeptRBtn_CheckedChanged);
            // 
            // groupByDeptRBtn
            // 
            this.groupByDeptRBtn.AutoSize = true;
            this.groupByDeptRBtn.Location = new System.Drawing.Point(12, 59);
            this.groupByDeptRBtn.Name = "groupByDeptRBtn";
            this.groupByDeptRBtn.Size = new System.Drawing.Size(140, 19);
            this.groupByDeptRBtn.TabIndex = 6;
            this.groupByDeptRBtn.TabStop = true;
            this.groupByDeptRBtn.Text = "Group By Department";
            this.groupByDeptRBtn.UseVisualStyleBackColor = true;
            this.groupByDeptRBtn.CheckedChanged += new System.EventHandler(this.groupByDeptRBtn_CheckedChanged);
            // 
            // salaryFilterRBtn
            // 
            this.salaryFilterRBtn.AutoSize = true;
            this.salaryFilterRBtn.Location = new System.Drawing.Point(12, 81);
            this.salaryFilterRBtn.Name = "salaryFilterRBtn";
            this.salaryFilterRBtn.Size = new System.Drawing.Size(132, 19);
            this.salaryFilterRBtn.TabIndex = 6;
            this.salaryFilterRBtn.TabStop = true;
            this.salaryFilterRBtn.Text = "Salary Above 150000";
            this.salaryFilterRBtn.UseVisualStyleBackColor = true;
            this.salaryFilterRBtn.CheckedChanged += new System.EventHandler(this.salaryFilterRBtn_CheckedChanged);
            // 
            // deptWithoutEmployee
            // 
            this.deptWithoutEmployee.AutoSize = true;
            this.deptWithoutEmployee.Location = new System.Drawing.Point(12, 107);
            this.deptWithoutEmployee.Name = "deptWithoutEmployee";
            this.deptWithoutEmployee.Size = new System.Drawing.Size(199, 19);
            this.deptWithoutEmployee.TabIndex = 6;
            this.deptWithoutEmployee.TabStop = true;
            this.deptWithoutEmployee.Text = "Departments Without Employees";
            this.deptWithoutEmployee.UseVisualStyleBackColor = true;
            this.deptWithoutEmployee.CheckedChanged += new System.EventHandler(this.deptWithoutEmployee_CheckedChanged);
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.AutoSize = true;
            this.displayAllBtn.Location = new System.Drawing.Point(12, 132);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(80, 19);
            this.displayAllBtn.TabIndex = 6;
            this.displayAllBtn.TabStop = true;
            this.displayAllBtn.Text = "Display All";
            this.displayAllBtn.UseVisualStyleBackColor = true;
            this.displayAllBtn.CheckedChanged += new System.EventHandler(this.displayAllBtn_CheckedChanged);
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EMPLOYEEID";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeId.Visible = false;
            // 
            // DepartmentId
            // 
            this.DepartmentId.DataPropertyName = "DEPARTMENTID";
            this.DepartmentId.HeaderText = "DepartmentId";
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.ReadOnly = true;
            this.DepartmentId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartmentId.Visible = false;
            // 
            // EmployeesDGView
            // 
            this.EmployeesDGView.AllowUserToAddRows = false;
            this.EmployeesDGView.AllowUserToDeleteRows = false;
            this.EmployeesDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.DepartmentId});
            this.EmployeesDGView.Location = new System.Drawing.Point(266, 55);
            this.EmployeesDGView.Name = "EmployeesDGView";
            this.EmployeesDGView.ReadOnly = true;
            this.EmployeesDGView.Size = new System.Drawing.Size(750, 311);
            this.EmployeesDGView.TabIndex = 1;
            this.EmployeesDGView.Text = "dataGridView1";
            this.EmployeesDGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDGView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select an employee to edit or delete";
            // 
            // Queries
            // 
            this.Queries.Controls.Add(this.displayEmpWithDeptRBtn);
            this.Queries.Controls.Add(this.groupByDeptRBtn);
            this.Queries.Controls.Add(this.displayAllBtn);
            this.Queries.Controls.Add(this.salaryFilterRBtn);
            this.Queries.Controls.Add(this.deptWithoutEmployee);
            this.Queries.Location = new System.Drawing.Point(12, 28);
            this.Queries.Name = "Queries";
            this.Queries.Size = new System.Drawing.Size(235, 157);
            this.Queries.TabIndex = 7;
            this.Queries.TabStop = false;
            this.Queries.Text = "Select Operation To Perform";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 771);
            this.Controls.Add(this.Queries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeDetailsGBox);
            this.Controls.Add(this.modifyDeptGBox);
            this.Controls.Add(this.EmployeesDGView);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.modifyDeptGBox.ResumeLayout(false);
            this.modifyDeptGBox.PerformLayout();
            this.employeeDetailsGBox.ResumeLayout(false);
            this.employeeDetailsGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGView)).EndInit();
            this.Queries.ResumeLayout(false);
            this.Queries.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartmentCBox;
        private System.Windows.Forms.DataGridView EmployeesDGView;
        private System.Windows.Forms.Button addDeptBtn;
        private System.Windows.Forms.GroupBox modifyDeptGBox;
        private System.Windows.Forms.Label deptName;
        private System.Windows.Forms.TextBox addDeptTBox;
        private System.Windows.Forms.Label selectDept;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox lastNameTBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.TextBox phoneNumberTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox salaryTBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.GroupBox employeeDetailsGBox;
        private System.Windows.Forms.Label hiredDate;
        private System.Windows.Forms.DateTimePicker hiredDateTPicker;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button updateEmpBtn;
        private System.Windows.Forms.Button deleteEmpBtn;
        private System.Windows.Forms.ComboBox ModifyDeptCBox;
        private System.Windows.Forms.TextBox updateDeptTBox;
        private System.Windows.Forms.Button updateDeptBtn;
        private System.Windows.Forms.Button deleteDeptBtn;
        private System.Windows.Forms.RadioButton displayEmpWithDeptRBtn;
        private System.Windows.Forms.RadioButton groupByDeptRBtn;
        private System.Windows.Forms.RadioButton salaryFilterRBtn;
        private System.Windows.Forms.RadioButton deptWithoutEmployee;
        private System.Windows.Forms.RadioButton displayAllBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Queries;
    }
}


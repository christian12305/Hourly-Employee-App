namespace HourlyEmployeeMaintenanceApp.Presentation
{
    partial class HourlyEmployeeMaintenanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colEmployeeId = new System.Windows.Forms.ColumnHeader();
            this.colSocialSecurity = new System.Windows.Forms.ColumnHeader();
            this.colFullName = new System.Windows.Forms.ColumnHeader();
            this.colDepartment = new System.Windows.Forms.ColumnHeader();
            this.colWeekStart = new System.Windows.Forms.ColumnHeader();
            this.colSalary = new System.Windows.Forms.ColumnHeader();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(21, 15);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(67, 15);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "&Employees:";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwEmployees
            // 
            this.lvwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmployeeId,
            this.colSocialSecurity,
            this.colFullName,
            this.colDepartment,
            this.colWeekStart,
            this.colSalary});
            this.lvwEmployees.FullRowSelect = true;
            this.lvwEmployees.GridLines = true;
            this.lvwEmployees.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwEmployees.Location = new System.Drawing.Point(22, 36);
            this.lvwEmployees.MultiSelect = false;
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(547, 139);
            this.lvwEmployees.TabIndex = 1;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            this.lvwEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Text = "Employee ID";
            this.colEmployeeId.Width = 90;
            // 
            // colSocialSecurity
            // 
            this.colSocialSecurity.Text = "Social Security";
            this.colSocialSecurity.Width = 90;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Full Name";
            this.colFullName.Width = 90;
            // 
            // colDepartment
            // 
            this.colDepartment.Text = "Department";
            this.colDepartment.Width = 90;
            // 
            // colWeekStart
            // 
            this.colWeekStart.Text = "Week Start";
            this.colWeekStart.Width = 90;
            // 
            // colSalary
            // 
            this.colSalary.Text = "Salary";
            this.colSalary.Width = 90;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(589, 36);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "&Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(589, 65);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "&View...";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(589, 94);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "&Modify...";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(589, 123);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove...";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // HourlyEmployeeMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(683, 208);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lvwEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Name = "HourlyEmployeeMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hourly Employee Maintenace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployees;
        private ListView lvwEmployees;
        private ColumnHeader colEmployeeId;
        private ColumnHeader colSocialSecurity;
        private ColumnHeader colFullName;
        private ColumnHeader colDepartment;
        private ColumnHeader colWeekStart;
        private ColumnHeader colSalary;
        private Button btnAddNew;
        private Button btnView;
        private Button btnModify;
        private Button btnRemove;
        private Button btnExit;
    }
}
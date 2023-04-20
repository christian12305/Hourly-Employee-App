namespace HourlyEmployeeMaintenanceApp.Presentation
{
    partial class AddOrViewEmployeeForm
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
            this.grpEmployeeData = new System.Windows.Forms.GroupBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.dtpWeekStart = new System.Windows.Forms.DateTimePicker();
            this.lblWeekStart = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtSocialSecurity = new System.Windows.Forms.TextBox();
            this.lblSocialSecurity = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEmployeeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeData
            // 
            this.grpEmployeeData.Controls.Add(this.txtHoursWorked);
            this.grpEmployeeData.Controls.Add(this.lblHoursWorked);
            this.grpEmployeeData.Controls.Add(this.txtPayRate);
            this.grpEmployeeData.Controls.Add(this.lblPayRate);
            this.grpEmployeeData.Controls.Add(this.dtpWeekStart);
            this.grpEmployeeData.Controls.Add(this.lblWeekStart);
            this.grpEmployeeData.Controls.Add(this.cboDepartment);
            this.grpEmployeeData.Controls.Add(this.lblDepartment);
            this.grpEmployeeData.Controls.Add(this.txtLastName);
            this.grpEmployeeData.Controls.Add(this.txtInitial);
            this.grpEmployeeData.Controls.Add(this.txtFirstName);
            this.grpEmployeeData.Controls.Add(this.lblFullName);
            this.grpEmployeeData.Controls.Add(this.txtSocialSecurity);
            this.grpEmployeeData.Controls.Add(this.lblSocialSecurity);
            this.grpEmployeeData.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeData.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeData.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeData.Name = "grpEmployeeData";
            this.grpEmployeeData.Size = new System.Drawing.Size(315, 273);
            this.grpEmployeeData.TabIndex = 0;
            this.grpEmployeeData.TabStop = false;
            this.grpEmployeeData.Text = "Employee Data";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(119, 232);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 23);
            this.txtHoursWorked.TabIndex = 15;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(15, 232);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(86, 15);
            this.lblHoursWorked.TabIndex = 14;
            this.lblHoursWorked.Text = "&Hours Worked:";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(119, 196);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 23);
            this.txtPayRate.TabIndex = 13;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(15, 199);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(70, 15);
            this.lblPayRate.TabIndex = 12;
            this.lblPayRate.Text = "Pay &Rate:   $";
            this.lblPayRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpWeekStart
            // 
            this.dtpWeekStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWeekStart.Location = new System.Drawing.Point(119, 160);
            this.dtpWeekStart.Name = "dtpWeekStart";
            this.dtpWeekStart.Size = new System.Drawing.Size(125, 23);
            this.dtpWeekStart.TabIndex = 11;
            // 
            // lblWeekStart
            // 
            this.lblWeekStart.AutoSize = true;
            this.lblWeekStart.Location = new System.Drawing.Point(15, 166);
            this.lblWeekStart.Name = "lblWeekStart";
            this.lblWeekStart.Size = new System.Drawing.Size(66, 15);
            this.lblWeekStart.TabIndex = 10;
            this.lblWeekStart.Text = "&Week Start:";
            this.lblWeekStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(119, 127);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 23);
            this.cboDepartment.TabIndex = 9;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(15, 130);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(73, 15);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "D&epartment:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(225, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(65, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(183, 93);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(36, 23);
            this.txtInitial.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(58, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 96);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full &Name:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSocialSecurity
            // 
            this.txtSocialSecurity.Location = new System.Drawing.Point(119, 59);
            this.txtSocialSecurity.Name = "txtSocialSecurity";
            this.txtSocialSecurity.Size = new System.Drawing.Size(100, 23);
            this.txtSocialSecurity.TabIndex = 3;
            // 
            // lblSocialSecurity
            // 
            this.lblSocialSecurity.AutoSize = true;
            this.lblSocialSecurity.Location = new System.Drawing.Point(15, 59);
            this.lblSocialSecurity.Name = "lblSocialSecurity";
            this.lblSocialSecurity.Size = new System.Drawing.Size(86, 15);
            this.lblSocialSecurity.TabIndex = 2;
            this.lblSocialSecurity.Text = "&Social Security:";
            this.lblSocialSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(119, 26);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 23);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(15, 29);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(76, 15);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "&Employee ID:";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(156, 291);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddOrViewEmployeeForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(339, 324);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpEmployeeData);
            this.Name = "AddOrViewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.AddOrViewEmployeeForm_Load);
            this.grpEmployeeData.ResumeLayout(false);
            this.grpEmployeeData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpEmployeeData;
        private Label lblEmployeeID;
        private Label lblHoursWorked;
        private TextBox txtPayRate;
        private Label lblPayRate;
        private DateTimePicker dtpWeekStart;
        private Label lblWeekStart;
        private ComboBox cboDepartment;
        private Label lblDepartment;
        private TextBox txtLastName;
        private TextBox txtInitial;
        private TextBox txtFirstName;
        private Label lblFullName;
        private TextBox txtSocialSecurity;
        private Label lblSocialSecurity;
        private TextBox txtEmployeeID;
        private TextBox txtHoursWorked;
        private Button btnOK;
        private Button btnCancel;
    }
}
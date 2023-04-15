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
            this.SuspendLayout();
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(22, 18);
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
            this.lvwEmployees.Location = new System.Drawing.Point(22, 36);
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(541, 189);
            this.lvwEmployees.TabIndex = 1;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // HourlyEmployeeMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 338);
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
    }
}
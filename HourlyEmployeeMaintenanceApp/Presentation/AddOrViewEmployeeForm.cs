/*
 * File: AddOrViewEmployee.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/19/2023
 * Purpose: This form is to add or view the information for an employee.
 */
using HourlyEmployeeMaintenanceApp.Domain;

namespace HourlyEmployeeMaintenanceApp.Presentation
{
    /// <summary>
    /// Form used to add or modify an employee.
    /// </summary>
    public partial class AddOrViewEmployeeForm : Form
    {
        /// <summary>Gets or sets the product data for the form. </summary>
        public HourlyEmployee? EmployeeData { get; set; }

        /// <summary>
        /// Creates a new form.
        /// </summary>
        public AddOrViewEmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the form when the Exit button is clicked.
        /// </summary>
        /// <param name="sender"> The control that raised the event. </param>
        /// <param name="e"> The event data. </param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrViewEmployeeForm_Load(object sender, EventArgs e)
        {
            //AQUI FALTA CONSIDERAR EL MODIFY FORM
            if (this.EmployeeData == null)
                this.Text = "Add New " + this.Text;
            else
            {
                txtEmployeeID.Text = EmployeeData.EmployeeID;
                txtEmployeeID.ReadOnly = true;
                txtSocialSecurity.Text = EmployeeData.SocialSecurity;
                txtSocialSecurity.ReadOnly = true;
                txtFirstName.Text = EmployeeData.FullName;
                txtFirstName.ReadOnly = true;
                cboDepartment.SelectedItem = EmployeeData.Department;
                cboDepartment.Enabled = false;
                dtpWeekStart.Value = EmployeeData.WeekStart;
                dtpWeekStart.Enabled = false;
                txtPayRate.Text = EmployeeData.PayRate.ToString();
                txtPayRate.ReadOnly = true;
                txtHoursWorked.Text = EmployeeData.HoursWorked.ToString();
                txtHoursWorked.ReadOnly = true;
                btnOK.Visible = false;
            }
        }
    }
}

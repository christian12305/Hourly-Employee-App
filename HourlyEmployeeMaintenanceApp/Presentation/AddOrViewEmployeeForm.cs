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
                this.Text = "View " + this.Text;
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

        /// <summary>
        /// Returns an employee with the input data when the OK button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                
                var empID = txtEmployeeID.Text;
                var SS = txtSocialSecurity.Text;
                var FN = txtFirstName.Text;
                var IN = txtInitial.Text;
                var LN = txtLastName.Text;
                var fullName = FN + " " + IN + " " + LN;
                var dpt = (CompanyDepartment) cboDepartment.SelectedItem;
                var wkStart = dtpWeekStart.Value;
                var payRate = Decimal.Parse(txtPayRate.Text);
                var hoursWorked = Int32.Parse(txtHoursWorked.Text);

                EmployeeData = new HourlyEmployee(empID, SS, fullName, dpt, wkStart, payRate, hoursWorked );

                MessageBox.Show($"The following will be saved:\n\n{EmployeeData.ToString("\n")}", 
                    "Save Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Determines whether the form has valid data.
        /// </summary>
        /// <returns>true if the data is valid; false otherwise.</returns>
        private bool IsValidData()
        {
            return
                FormValidator.IsPresent(txtEmployeeID) &&
                FormValidator.MatchesPattern(txtEmployeeID, HourlyEmployeeConsts.IdPattern) &&
                
                FormValidator.IsPresent(txtSocialSecurity) &&
                FormValidator.MatchesPattern(txtSocialSecurity, HourlyEmployeeConsts.SSPattern) &&
                
                FormValidator.IsPresent(txtFirstName) &&
                FormValidator.MatchesPattern(txtFirstName, HourlyEmployeeConsts.NamePattern) &&

                FormValidator.MatchesPattern(txtInitial, "[A-Z{1}]?") &&

                FormValidator.IsPresent(txtLastName) &&
                FormValidator.MatchesPattern(txtLastName, HourlyEmployeeConsts.NamePattern) &&

                FormValidator.IsSelected(cboDepartment) &&

                FormValidator.IsPresent(txtPayRate) &&
                FormValidator.IsDecimal(txtPayRate) &&
                FormValidator.IsWithinRange(txtPayRate, HourlyEmployeeConsts.MinPayRate, HourlyEmployeeConsts.MaxPayRate)&&

                FormValidator.IsPresent(txtHoursWorked) &&
                FormValidator.IsInt32(txtHoursWorked) && 
                FormValidator.IsWithinRange(txtHoursWorked, HourlyEmployeeConsts.MinHoursWorked, HourlyEmployeeConsts.MaxHoursWorked);

                ;
        }
    }
}

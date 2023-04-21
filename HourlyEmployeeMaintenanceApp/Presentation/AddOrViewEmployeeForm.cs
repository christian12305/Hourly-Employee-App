/*
 * File: AddOrViewEmployee.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/20/2023
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

        /// <summary>Flag to determine if its the view or a modify option. </summary>
        public bool isView { get; set; }

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

        /// <summary>
        /// If form has data, view or modify, else its Add.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void AddOrViewEmployeeForm_Load(object sender, EventArgs e)
        {
            cboDepartment.Items.Add(CompanyDepartment.HumanResources);
            cboDepartment.Items.Add(CompanyDepartment.Marketing);
            cboDepartment.Items.Add(CompanyDepartment.Finance);
            cboDepartment.Items.Add(CompanyDepartment.Sales);
            cboDepartment.Items.Add(CompanyDepartment.InformationTechnology);

            dtpWeekStart.MaxDate = DateTime.Now;
            dtpWeekStart.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1, DateTime.Now.Day);

            if (this.EmployeeData == null)
                this.Text = "Add New " + this.Text;
            else if( this.EmployeeData != null && isView == true)
            {
                this.Text = "View " + this.Text;
                txtEmployeeID.Text = EmployeeData.EmployeeID;
                txtEmployeeID.ReadOnly = true;
                txtSocialSecurity.Text = EmployeeData.SocialSecurity;
                txtSocialSecurity.ReadOnly = true;
                String[] arr = EmployeeData.FullName.Split(" ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                        txtFirstName.Text = arr[0];

                    if (i == 1)
                        txtInitial.Text = arr[1];

                    if (i == 2)
                        txtLastName.Text = arr[2];
                }
                txtFirstName.ReadOnly = true;
                txtInitial.ReadOnly = true;
                txtLastName.ReadOnly = true;
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
            else if(this.EmployeeData != null && isView == false)
            {
                this.Text = "Modify " + this.Text;
                txtEmployeeID.Text = EmployeeData!.EmployeeID;
                txtEmployeeID.ReadOnly = true;
                txtSocialSecurity.Text = EmployeeData.SocialSecurity;
                String[] arr = EmployeeData.FullName.Split(" ");
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i == 0)
                        txtFirstName.Text = arr[0];

                    if(i == 1)
                        txtInitial.Text = arr[1];

                    if(i == 2)
                        txtLastName.Text = arr[2];
                }
                cboDepartment.SelectedItem = EmployeeData.Department;
                dtpWeekStart.Value = EmployeeData.WeekStart;
                txtPayRate.Text = EmployeeData.PayRate.ToString("f2");
                txtHoursWorked.Text = EmployeeData.HoursWorked.ToString("d");
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
                var empID = txtEmployeeID.Text.Trim();
                var SS = txtSocialSecurity.Text.Trim();
                var FN = txtFirstName.Text.Trim();
                var IN = txtInitial.Text.Trim();
                var LN = txtLastName.Text.Trim();
                var fullName = FN + " " + IN + " " + LN;
                var dpt = (CompanyDepartment) cboDepartment.SelectedIndex;
                var wkStart = dtpWeekStart.Value;
                var payRate = Decimal.Parse(txtPayRate.Text);
                var hoursWorked = Int32.Parse(txtHoursWorked.Text);

                EmployeeData = new HourlyEmployee(empID, SS, fullName, dpt, wkStart, payRate, hoursWorked);

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

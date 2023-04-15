/*
 * File: AddOrViewEmployee.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/15/2023
 * Purpose: This form is to add or view the information for an employee.
 */
namespace HourlyEmployeeMaintenanceApp.Presentation
{
    public partial class AddOrViewEmployeeForm : Form
    {
        public AddOrViewEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

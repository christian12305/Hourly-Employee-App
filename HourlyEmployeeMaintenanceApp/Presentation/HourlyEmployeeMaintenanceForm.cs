/*
 * File: HourlyEmployeeMaintenanceForm.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/15/2023
 * Purpose: This form maintains the hourly employee list up to date.
 */
namespace HourlyEmployeeMaintenanceApp.Presentation
{
    public partial class HourlyEmployeeMaintenanceForm : Form
    {
        public HourlyEmployeeMaintenanceForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

/*
 * File: HourlyEmployeeMaintenanceForm.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/20/2023
 * Purpose: This form maintains the hourly employee list up to date.
 */
using HourlyEmployeeMaintenanceApp.Domain;

namespace HourlyEmployeeMaintenanceApp.Presentation
{
    public partial class HourlyEmployeeMaintenanceForm : Form
    {
        /// <summary>The list of the hourly employees. </summary>
        private HourlyEmployeeList employees;

        /// <summary>
        /// Creates a new form.
        /// </summary>
        public HourlyEmployeeMaintenanceForm()
        {
            InitializeComponent();
            employees = new HourlyEmployeeList();
            employees.ContentsChanged += new HourlyEmployeeList.ChangeEventHandler(HandleListChange);
        }

        /// <summary>
        /// Save the given list of employees and fills the product list view
        /// when the contents of the list changes.
        /// </summary>
        /// <param name="employees">The list of employees.</param>
        private void HandleListChange(HourlyEmployeeList employees)
        {
            employees.Save();
            FillHourlyEmployeeListView();
        }

        /// <summary>
        /// Fills the product listview with the contents of the list of products.
        /// </summary>
        private void FillHourlyEmployeeListView()
        {
            lvwEmployees.Items.Clear();

            for (int i = 0; i < employees.Count(); i++)
            {
                HourlyEmployee employee = employees[i];

                string[] fields =
                {
                    employee.EmployeeID, employee.SocialSecurity, employee.FullName,
                    employee.Department.ToString(), employee.WeekStart.ToString(), employee.PayRate.ToString("c"),
                    employee.HoursWorked.ToString()
                };

                var item = new ListViewItem(fields);
                lvwEmployees.Items.Add(item);
            }
        }

        /// <summary>
        /// Closes the form when the Exit button is clicked.
        /// </summary>
        /// <param name="sender"> The control that raised the event. </param>
        /// <param name="e"> The event data. </param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Adds a new employee to the list of employees when the Add New button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event. </param>
        /// <param name="e">The event data.</param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmAddEmployee = new AddOrViewEmployeeForm();
            var result = frmAddEmployee.ShowDialog();

            if (result == DialogResult.OK && frmAddEmployee.EmployeeData != null)
                employees += frmAddEmployee.EmployeeData;
            
        }

        /// <summary>
        /// If an employee is selected, displays the employee when the View button is clicked.
        /// </summary>
        /// <param name="sender"> The control that raised the event. </param>
        /// <param name="e"> The event data. </param>
        private void btnView_Click(object sender, EventArgs e)
        {

            if (lvwEmployees.SelectedIndices.Count == 0)
                MessageBox.Show("No employee was selected.", "View Employee",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                var idx = lvwEmployees.SelectedIndices[0];
                var employee = employees[idx];

                var frmViewEmployee = new AddOrViewEmployeeForm()
                {
                    EmployeeData = employee,
                    isView = true
                };

                frmViewEmployee.ShowDialog();
            }
        }

        /// <summary>
        /// Modifies an employee in the list of employees when the Modify button is clicked.
        /// </summary>
        /// <param name="sender"> The control that raised the event. </param>
        /// <param name="e"> The event data. </param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedIndices.Count == 0)
                MessageBox.Show("No employee was selected.", "Modify Employee", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                var idx = lvwEmployees.SelectedIndices[0];
                var employee = employees[idx];

                var frmModifyEmployee = new AddOrViewEmployeeForm()
                {
                    EmployeeData = employee,
                    isView = false
                };

                var result = frmModifyEmployee.ShowDialog();

                if (result == DialogResult.OK)
                    employees[idx] = frmModifyEmployee.EmployeeData;
            }
        }

        /// <summary>
        /// Removes an employee from the list of employees when the Remove button is clicked.
        /// </summary>
        /// <param name="sender"> The control that raised the event. </param>
        /// <param name="e"> The event data. </param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedIndices.Count == 0)
                MessageBox.Show("No employee was selected.", "Remove Employee",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var idx = lvwEmployees.SelectedIndices[0];
                var employee = employees[idx];

                var answer = MessageBox.Show(
                    $"Are you sure you want to remove {employee.FullName}?", "Remove Employee",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (answer == DialogResult.Yes)
                    employees -= employee;
            }
        }

        /// <summary>
        /// Gets and display the list of employees when the form loads.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data</param>
        private void HourlyEmployeeMaintenanceForm_Load(object sender, EventArgs e)
        {
            employees.Fill();
            FillHourlyEmployeeListView();
        }
    }
}

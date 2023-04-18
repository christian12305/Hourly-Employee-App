/*
 * File: HourlyEmployee.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/17/2023
 * Purpose: This class is for the hourly employee.
 */
namespace HourlyEmployeeMaintenanceApp.Domain
{
    /// <summary>
    /// An hourly employee in the company.
    /// </summary>
    public class HourlyEmployee
    {
        /// <summary> Default value for the pay rate </summary>
        private const decimal DefaultPayRate = 8.50m;

        /// <summary> Default value for the hours worked </summary>
        private const int DefaultHoursWorked = 40;

        /// <summary> Gets the ID for the employee </summary>
        public string EmployeeID { get; }

        /// <summary> Gets the social security for the employee </summary>
        public string SocialSecurity { get; }

        /// <summary> Gets or initializes the full name of the employee </summary>
        public string FullName { get; init; }

        /// <summary> Get or initializes the department where for the employee.
        public CompanyDepartment Department { get; init; }

        /// <summary> Get or initializes the week the employee started at </summary>
        public DateOnly WeekStart { get; init; }

        /// <summary> Get or initializes the pay rate for the employee. </summary>
        public decimal PayRate { get; init; }

        /// <summary> Get or initializes the hours worked by the employee. </summary>
        public int HoursWorked { get; init; }

        /// <summary>
        /// Creates a new Hourly Employee with the given data and an optional payRate and Hours Worked
        /// </summary>
        /// <param name="employeeID">The ID of the employee </param>
        /// <param name="socialSecurity">The social security of the employee</param>
        /// <param name="fullName">The full name of the employee</param>
        /// <param name="department">The department of the employee</param>
        /// <param name="weekStart">The week the employee started</param>
        /// <param name="payRate">The pay rate for the employee</param>
        /// <param name="hoursWorked">The amount of hours worked by the employee</param>
        public HourlyEmployee(string employeeID, string socialSecurity, string fullName,
            CompanyDepartment department, DateOnly weekStart, decimal payRate = DefaultPayRate, int hoursWorked = DefaultHoursWorked) =>
            (EmployeeID, SocialSecurity, FullName, Department, WeekStart, PayRate, HoursWorked) = (employeeID, socialSecurity, fullName, department, weekStart, payRate, hoursWorked);

        /// <summary>
        /// Returns the product of the payrate and the number of hours worked.
        /// </summary>
        /// <returns>A decimal representation for the salary of the week.</returns>
        public decimal WeeklySalary()
        {
            int hoursWorked = HoursWorked;
            decimal payRate = PayRate;

            decimal weeklySalary = 0;

            //Overtime pay/ Regular pay
            if (hoursWorked > 40)
            {
                double overtime = hoursWorked - 40;

                weeklySalary = (decimal)overtime * (payRate * 2.0m);

                weeklySalary += 40 * payRate;
            }
            else
                weeklySalary = (decimal)hoursWorked * payRate;

            return weeklySalary;
        }

        /// <summary>
        /// Returns a string representation of the hourly employee.
        /// </summary>
        /// <param name="sep">The field separator.</param>
        /// <returns>The string representation of the Hourly Employee.</returns>
        public string ToString(String sep) =>
            $"EmployeeID: {EmployeeID}{sep}Social Security: {SocialSecurity}{sep}" +
            $"Full Name: {FullName}{sep}Department: {Department}{sep}" +
            $"Week Start: {WeekStart.ToShortDateString}PayRate: {PayRate}Hours Worked: {HoursWorked}" +
            $"Weekly Salary: {WeeklySalary}";

        /// <summary>
        /// Returns a string representation of the hourly employee.
        /// </summary>
        /// <returns>The string representation of the Hourly Employee.</returns>
        public override string ToString() => ToString(", ");
    }
}

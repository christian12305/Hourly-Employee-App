/*
 * File: HourlyEmployeeList.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/15/2023
 * Purpose: This class contains the list for the hourly employee.
 */
namespace HourlyEmployeeMaintenanceApp.Domain
{
    public class HourlyEmployeeList
    {
        /// <summary>The contents of the internal list of hourly employees. </summary>
        private List<HourlyEmployee> hourlyEmployees;

        /// <summary>
        /// Delegate for the change event handler.
        /// </summary>
        /// <param name="employees">The list of hourly employees</param>
        public delegate void ChangeEventHandler(HourlyEmployeeList employees);

    }
}

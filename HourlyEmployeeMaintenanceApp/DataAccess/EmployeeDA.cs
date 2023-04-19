/*
 * File: EmployeeDA.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/18/2023
 * Purpose: This class contains access to the data of employees.
 */
using HourlyEmployeeMaintenanceApp.Domain;

namespace HourlyEmployeeMaintenanceApp.DataAccess
{
    /// <summary>
    /// This class represents an employee data access layer.
    /// </summary>
    public static class EmployeeDA
    {
        /// <summary>
        /// Gets the list of the employees
        /// </summary>
        /// <returns>the list of products.</returns>
        public static List<HourlyEmployee> GetEmployees()
        {
            var employees = new List<HourlyEmployee>()
            {
                //Remember to validate SSecurityNum
                new HourlyEmployee("HW-0011", "123456789", "Juan", CompanyDepartment.Sales, DateTime.Now.Date, 8.50m, 40),
                new HourlyEmployee("HW-0022", "987654321", "Pedro", CompanyDepartment.Finance, DateTime.Now.Date, 9.50m, 48),
                new HourlyEmployee("HW-0033", "111222333", "Luis", CompanyDepartment.InformationTechnology, DateTime.Now.Date, 11.50m, 25)
            };
            return employees;
        }
    }
}

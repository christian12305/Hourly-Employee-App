/*
 * File: HourlyEmployeeConsts.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/18/2023
 * Purpose: This class contains the constants to be used throughout the different classes.
 */
namespace HourlyEmployeeMaintenanceApp.Domain
{

    public static class HourlyEmployeeConsts
    {
        /// <summary>Regular expression pattern for the id of the employee. </summary>
        public const string IdPattern = @"HW-\d{4}";
        /// <summary>Regular expression pattern for the name of the employee. </summary>
        public const string NamePattern = @"[A-Z]{1}[a-z]{3,15}";
        /// <summary>Regular expression pattern for the social security number of the employee.  </summary>
        public const string SSPattern = @"[\d{3}-\d{2}-\d{4}]";
        /// <summary>Minimum pay rate for the employee. </summary>
        public const decimal MinPayRate = 8.50m;
        /// <summary>Maximimum pay rate for the employee. </summary>
        public const decimal MaxPayRate = 50.0m;
        /// <summary>Minimum hours worked for the employee. </summary>
        public const int MinHoursWorked = 0;
        /// <summary>Maximum hours worked for the employee. </summary>
        public const int MaxHoursWorked = 60;
    }
}

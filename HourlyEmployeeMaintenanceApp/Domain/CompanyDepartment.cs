/*
 * File: CompanyDepartment.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/15/2023
 * Purpose: This class is an enumeration for the company departments.
 */
namespace HourlyEmployeeMaintenanceApp.Domain
{
    /// <summary>
    /// The set of allowed Company Departments.
    /// </summary>
    public enum CompanyDepartment
    {
        /// <summary>
        /// A department classified as Finance.
        /// </summary>
        Finance,
        /// <summary>
        /// A department classified as Sales
        /// </summary>
        Sales,
        /// <summary>
        /// A department classified as Marketing
        /// </summary>
        Marketing,
        /// <summary>
        /// A department classified as Human Resources
        /// </summary>
        HumanResources,
        /// <summary>
        /// A department classified as Information Technology
        /// </summary>
        InformationTechnology
    }
}

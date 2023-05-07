/*
 * File: EmployeeBinaryDA.cs
 * Author: Christian J. Ramos Ortega
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/07/2023
 * Purpose: This class represents an employee data access layer for an binary file.
 */
using HourlyEmployeeMaintenanceApp.Domain;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml;

namespace HourlyEmployeeMaintenanceApp.DataAccess
{
    /// <summary>
    /// This class represents an employee data access layer for an XML file.
    /// </summary>
    static class HourlyEmployeeBinaryDA
    {
        /// <summary>The path of the data directory (folder).</summary>
        private const string DirPath = @"..\..\..\Data";

        /// <summary>The path of the data file.</summary>
        private const string FilePath = DirPath + @"\employees.bin";

        /// <summary>
        /// Gets the list of employees in an XML file.
        /// </summary>
        /// <returns>the list of employee.</returns>
        public static List<HourlyEmployee> GetEmployees()
        {
            var employees = new List<HourlyEmployee>();

            using var reader = new BinaryReader(
                    new FileStream(FilePath, FileMode.Open, FileAccess.Read));

            while (reader.PeekChar() != -1)
            {
                string EmployeeID = reader.ReadString();
                string SocialSecurity = reader.ReadString();
                string FullName = reader.ReadString();
                CompanyDepartment Department = (CompanyDepartment)reader.ReadInt32();
                DateTime WeekStart = DateTime.Parse(reader.ReadString());
                decimal payRate = reader.ReadDecimal();
                int HoursWorked = reader.ReadInt32();

                employees.Add(new HourlyEmployee(EmployeeID, SocialSecurity, FullName, Department, WeekStart, payRate, HoursWorked));
            }

            return employees;
        }

        /// <summary>
        /// Saves a list of employees in an XML file.
        /// </summary>
        /// <param name="employees">The list of employees being saved.</param>
        public static void SaveEmployees(List<HourlyEmployee> employees)
        {
            using var writer = new BinaryWriter(
                                new FileStream(FilePath, FileMode.Create, FileAccess.Write));

            foreach (var employee in employees)
            {
                writer.Write(employee.EmployeeID);
                writer.Write(employee.SocialSecurity);
                writer.Write(employee.FullName);
                writer.Write((int)employee.Department);
                writer.Write(employee.WeekStart.ToString());
                writer.Write(employee.PayRate);
                writer.Write(employee.HoursWorked);
            }
        }
    }
}

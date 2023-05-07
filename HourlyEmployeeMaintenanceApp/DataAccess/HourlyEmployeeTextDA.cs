/*
 * File: EmployeeTextDA.cs
 * Author: Christian J. Ramos Ortega
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/07/2023
 * Purpose: This class represents an employee data access layer for a text file.
 */
using HourlyEmployeeMaintenanceApp.Domain;

namespace HourlyEmployeeMaintenanceApp.DataAccess
{
    static class HourlyEmployeeTextDA
    {
        /// <summary>The path of the data directory (folder).</summary>
        private const string DirPath = @"..\..\..\Data";

        /// <summary>The path of the data file.</summary>
        private const string FilePath = DirPath + @"\employees.csv";

        /// <summary>The field separator.</summary>
        private const char FieldSep = ',';

        /// <summary>
        /// Gets the list of hourly employees in a text file.
        /// </summary>
        /// <returns>the list of hourly employees.</returns>
        public static List<HourlyEmployee> GetEmployees()
        {
            var employees = new List<HourlyEmployee>();

            using TextReader reader = new StreamReader(FilePath);

            _ = reader.ReadLine();   // ignore header
            while (reader.Peek() != -1)
            {
                string[] fields = reader.ReadLine()!.Split(FieldSep);

                string EmployeeID = fields[0];
                string SocialSecurity = fields[1];
                string FullName = fields[2];
                CompanyDepartment Department = Enum.Parse<CompanyDepartment>(fields[3]);
                DateTime WeekStart = DateTime.Parse(fields[4]);
                decimal payRate = decimal.Parse(fields[5]);
                int HoursWorked = int.Parse(fields[6]);

                employees.Add(new HourlyEmployee(EmployeeID, SocialSecurity, FullName, Department, WeekStart, payRate, HoursWorked));
            }
            return employees;
        }

        /// <summary>
        /// Saves a list of employees in a text file.
        /// </summary>
        /// <param name="employees">The list of employees being saved.</param>
        public static void SaveEmployees(List<HourlyEmployee> employees)
        {
            using TextWriter writer = new StreamWriter(FilePath);

            writer.WriteLine($"EmployeeID{FieldSep}SocialSecurity{FieldSep}FullName{FieldSep}Department{FieldSep}WeekStart{FieldSep}payRate{FieldSep}HoursWorked");
            foreach (var employee in employees)
            {
                writer.Write(employee.EmployeeID + FieldSep);
                writer.Write(employee.SocialSecurity + FieldSep);
                writer.Write(employee.FullName + FieldSep);
                writer.Write(employee.Department.ToString() + FieldSep);
                writer.Write(employee.WeekStart.ToString() + FieldSep);
                writer.Write(employee.PayRate.ToString("#0.00") + FieldSep);
                writer.WriteLine(employee.HoursWorked);
            }
        }
    }
}

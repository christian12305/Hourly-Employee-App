/*
 * File: EmployeeJsonDA.cs
 * Author: Christian J. Ramos Ortega
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/07/2023
 * Purpose: This class represents an employee data access layer for an binary file.
 */
using HourlyEmployeeMaintenanceApp.Domain;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HourlyEmployeeMaintenanceApp.DataAccess
{
    /// <summary>
    /// This class represents an employee data access layer for an XML file.
    /// </summary>
    static class HourlyEmployeeJsonDA
    {
        /// <summary>The path of the data directory (folder).</summary>
        private const string DirPath = @"..\..\..\Data";

        /// <summary>The path of the data file.</summary>
        private const string FilePath = DirPath + @"\employees.json";

        /// <summary>
        /// Gets the list of employees in an JSON file.
        /// </summary>
        /// <returns>the list of employee.</returns>
        public static List<HourlyEmployee> GetEmployees()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            options.Converters.Add(new JsonStringEnumConverter());

            string jsonString = File.ReadAllText(FilePath);
            List<HourlyEmployee>? employees = JsonSerializer.Deserialize<List<HourlyEmployee>>(jsonString, options);
            return employees!;
        }

        /// <summary>
        /// Saves a list of employees in an XML file.
        /// </summary>
        /// <param name="employees">The list of employees being saved.</param>
        public static void SaveEmployees(List<HourlyEmployee> employees)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            options.Converters.Add(new JsonStringEnumConverter());

            string jsonString = JsonSerializer.Serialize(employees, options);
            File.WriteAllText(FilePath, jsonString);
        }
    }
}

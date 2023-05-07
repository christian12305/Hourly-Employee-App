/*
 * File: EmployeeXMLDA.cs
 * Author: Christian J. Ramos Ortega
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/07/2023
 * Purpose: This class represents an employee data access layer for an XML file.
 */
using HourlyEmployeeMaintenanceApp.Domain;
using System.Text;
using System.Xml;

namespace HourlyEmployeeMaintenanceApp.DataAccess
{
    /// <summary>
    /// This class represents an employee data access layer for an XML file.
    /// </summary>
    static class HourlyEmployeeBinary
    {
        /// <summary>The path of the data directory (folder).</summary>
        private const string DirPath = @"..\..\..\Data";

        /// <summary>The path of the data file.</summary>
        private const string FilePath = DirPath + @"\employees.xml";

        /// <summary>
        /// Gets the list of products in an XML file.
        /// </summary>
        /// <returns>the list of products.</returns>
        public static List<HourlyEmployee> GetEmployees()
        {
            var employees = new List<HourlyEmployee>();

            var settings = new XmlReaderSettings
            {
                IgnoreWhitespace = true
            };

            using XmlReader reader = XmlReader.Create(FilePath, settings);

            if (reader.ReadToDescendant("employee"))
            {
                do
                {
                    string EmployeeID = reader.GetAttribute("employeeid")!;
                    reader.ReadStartElement("employee");

                    string SocialSecurity = reader.ReadElementContentAsString();
                    string FullName = reader.ReadElementContentAsString();
                    CompanyDepartment Department = Enum.Parse<CompanyDepartment>(reader.ReadElementContentAsString());
                    DateTime WeekStart = DateTime.Parse(reader.ReadElementContentAsString());
                    decimal payRate = reader.ReadElementContentAsDecimal();
                    int HoursWorked = reader.ReadElementContentAsInt();

                    employees.Add(new HourlyEmployee(EmployeeID, SocialSecurity, FullName, Department, WeekStart, payRate, HoursWorked));


                } while (reader.ReadToNextSibling("employee"));
            }
            return employees;
        }

        /// <summary>
        /// Saves a list of employees in an XML file.
        /// </summary>
        /// <param name="employees">The list of employees being saved.</param>
        public static void SaveEmployees(List<HourlyEmployee> employees)
        {
            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = true
            };

            using XmlWriter writer = XmlWriter.Create(FilePath, settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("employees");

            foreach (var employee in employees)
            {
                writer.WriteStartElement("employee");

                writer.WriteAttributeString("employeeid", employee.EmployeeID);
                writer.WriteElementString("socialsecurity", employee.SocialSecurity);
                writer.WriteElementString("fullname", employee.FullName);
                writer.WriteElementString("department", employee.Department.ToString());
                writer.WriteElementString("weekstart", employee.WeekStart.ToString());
                writer.WriteElementString("payrate", employee.PayRate.ToString("#0.00"));
                writer.WriteElementString("hoursworked", employee.HoursWorked.ToString());

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
    }
}

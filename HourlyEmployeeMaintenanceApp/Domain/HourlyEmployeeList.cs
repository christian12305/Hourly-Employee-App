/*
 * File: HourlyEmployeeList.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/18/2023
 * Purpose: This class contains the list for the hourly employee.
 */
using EmployeeDA = HourlyEmployeeMaintenanceApp.DataAccess.HourlyEmployeeJsonDA;

namespace HourlyEmployeeMaintenanceApp.Domain
{
    public class HourlyEmployeeList
    {
        /// <summary>The contents of the internal list of hourly employees. </summary>
        private List<HourlyEmployee> contents;

        /// <summary>
        /// Delegate for the change event handler.
        /// </summary>
        /// <param name="employees">The list of hourly employees</param>
        public delegate void ChangeEventHandler(HourlyEmployeeList employees);

        /// <summary>
        /// Event that signals that the contents of the list of products has changed.
        /// </summary>
        public event ChangeEventHandler? ContentsChanged;

        /// <summary>
        /// Creates a new list of products.
        /// </summary>
        public HourlyEmployeeList()
        {
            contents = new List<HourlyEmployee>();
        }

        /// <summary>
        /// Gets the number of employees.
        /// </summary>
        /// <returns>The amount of employees</returns>
        public int Count() => contents.Count;

        /// <summary>
        /// Fills the list with data from the data store.
        /// </summary>
        public void Fill() => contents = EmployeeDA.GetEmployees();

        /// <summary>
        /// Saves the list of employees.
        /// </summary>
        public void Save() => EmployeeDA.SaveEmployees(contents);

        /// <summary>
        /// Adds an employee to the list
        /// </summary>
        /// <param name="employee">The employee to be added </param>
        public void Add(HourlyEmployee employee)
        {
            contents.Add(employee);
            ContentsChanged?.Invoke(this);
        }

        /// <summary>
        /// Removes an employee from the list.
        /// </summary>
        /// <param name="employee">The employee to be removed</param>
        public void Remove(HourlyEmployee employee)
        {
            contents.Remove(employee);
            ContentsChanged?.Invoke(this);
        }

        /// <summary>
        /// Adds an employee to a list of employees.
        /// </summary>
        /// <param name="employees">The list of employees</param>
        /// <param name="employee">The employee to be added</param>
        /// <returns>The modified list of employess</returns>
        public static HourlyEmployeeList operator +(HourlyEmployeeList employees, HourlyEmployee employee)
        {
            employees.Add(employee);
            return employees;
        }

        /// <summary>
        /// Removes an employee from a list of employees.
        /// </summary>
        /// <param name="employees">The list of employees</param>
        /// <param name="employee">The employee to be added</param>
        /// <returns>The modified list of employess</returns>
        public static HourlyEmployeeList operator -(HourlyEmployeeList employees, HourlyEmployee employee)
        {
            employees.Remove(employee);
            return employees;
        }

        /// <summary>
        /// Searches or modifies the employee with the given index.
        /// </summary>
        /// <param name="index">The index of the searched or modified employee.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the index is out of range.
        /// </exception>
        /// <returns></returns>
        public HourlyEmployee this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value;
                ContentsChanged?.Invoke(this);
            }
        }

        /// <summary>
        /// Searches the employee with the given id.
        /// </summary>
        /// <param name="id">The id of the searched employee</param>
        /// <returns>The searched employee if found, null otherwise.</returns>
        public HourlyEmployee? this[string id]
        {
            get
            {
                foreach(var employee in contents) 
                    if(employee.EmployeeID == id)
                        return employee;
                return null;
            }
        }
    }
}

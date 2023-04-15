/*
 * File: HourlyEmployeeMaintenanceMain.cs
 * Author: Christian Ramos Ortega 841184582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 04/15/2023
 * Purpose: This is the main class for the HourlyEmployeeMaintenace App.
 */
using HourlyEmployeeMaintenanceApp.Presentation;

namespace HourlyEmployeeMaintenanceApp
{
    internal static class HourlyEmployeeMaintenanceMain
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HourlyEmployeeMaintenanceForm());
        }
    }
}
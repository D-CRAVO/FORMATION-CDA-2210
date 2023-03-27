using System.Collections.Generic;

namespace WFListBox
{
    internal static class Program
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
            
            string[] list = new string[] { "Denis", "Jean-Pierre", "Jean-Paul", "Arnaud" };
            Application.Run(new FormListBox(list));
        }
    }
}
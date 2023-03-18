namespace Emprunts
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
            //Application.Run(new Emprunts());
            Application.Run(new FormEmprunts(150000, 0.08, 120, "Trimestrielle"));
        }
    }
}
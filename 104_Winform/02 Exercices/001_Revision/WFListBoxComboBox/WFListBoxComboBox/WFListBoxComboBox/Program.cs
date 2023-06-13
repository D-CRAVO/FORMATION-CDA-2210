namespace WFListBoxComboBox
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
            List<string> Countries = new List<string> { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce" };
            Application.Run(new Formulaire(Countries));
        }
    }
}
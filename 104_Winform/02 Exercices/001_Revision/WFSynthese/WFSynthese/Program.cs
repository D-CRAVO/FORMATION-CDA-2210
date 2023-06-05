using CLEmprunts;

namespace WFSynthese
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
            Emprunt empruntTest = new Emprunt("Dupont", 150000, 120, Emprunt.EnumPeriodicite.Trimestrielle, 0.08f);
            Application.Run(new Formulaire(empruntTest));
        }
    }
}
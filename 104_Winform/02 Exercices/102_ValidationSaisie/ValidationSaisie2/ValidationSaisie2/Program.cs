using ClassLibraryValidationSaisie2;

namespace ValidationSaisie2
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
            Application.Run(new FormulaireSaisie2());

            Controles2 monControle = new Controles2();
            //ValideNom(monControle.Nom);
        }
    }
}
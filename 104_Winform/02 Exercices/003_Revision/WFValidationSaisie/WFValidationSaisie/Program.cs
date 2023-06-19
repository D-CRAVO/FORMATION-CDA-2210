namespace WFValidationSaisie
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
            CLTransactions.Transaction maTransaction = new CLTransactions.Transaction("Duranton", new DateOnly(2023, 06, 20),
                3567.68f, "13013");
            Application.Run(new Formulaire(maTransaction));
        }
    }
}
using CLStagiaires;

namespace WFStagiairesAuCRM
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
            Stagiaire stagiaire = new Stagiaire("CRAVO", "David", new DateOnly(2022, 10, 01), new DateOnly(2024, 03, 08), Stagiaire.EnumSection.CDA);
            Application.Run(new InscriptionStagiaireForm(stagiaire));
        }
    }
}
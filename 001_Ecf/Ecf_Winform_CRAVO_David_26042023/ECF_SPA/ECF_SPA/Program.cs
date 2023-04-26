using ECF_SPA.Data;
using Microsoft.EntityFrameworkCore;

namespace ECF_SPA
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

            SpaContext context = new SpaContext();
            ECF_SPA.Models.Chat cleopatre = new ECF_SPA.Models.Chat();
            cleopatre = context.Chats.Find(250260111111111);

            Application.Run(new FormChat(cleopatre, context));
        }
    }
}
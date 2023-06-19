using ClassLibraryChat;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;
using WinFormsECF_SPA.Models;

namespace WinFormsECF_SPA
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
            SpaContext dbContext;
            dbContext = new SpaContext();
            
            //chat de la bdd
            Chat monChat = dbContext.Chats.Find(250260111111111);

            ClassChat petitNouveau = new ClassChat(monChat.NumeroPuce,monChat.Nom,monChat.Age,monChat.Race);

            Application.Run(new FormChat2(petitNouveau));
        }
    }
}
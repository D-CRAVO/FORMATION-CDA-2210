using ClassLibraryControles;

namespace ListBox
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
            Application.Run(new FormListBox());

            //List<string> list = new List<string>() { "a", "z", "z" };
            //bool result1 = Controles.ControleDoublons("y", list);
            //bool result2 = Controles.ControleDoublons("a", list);
        }
    }
}
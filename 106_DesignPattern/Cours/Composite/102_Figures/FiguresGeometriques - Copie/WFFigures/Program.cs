namespace WFFigures
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
            

            CLFigure.Rectangle rectangle = new CLFigure.Rectangle(50, 100, 0, 0);
            rectangle.Accept(new VisiteurDeFigurePourWinform());

            CLFigure.Cercle cercle = new CLFigure.Cercle(50, 150, 150);
            cercle.Accept(new VisiteurDeFigurePourWinform());

            Application.Run(new FormFigures(cercle));
        }
    }
}
using LibraryBanque;

namespace ConsoleAppBanque
{
    internal class program
    {
        static void Main(string[] args)
        {
            try
            {
                Banque cm = new Banque("Crédit Mutuel", "Blois");

                cm.AjouteCompte(1, "David", 5000, -350);
                cm.AjouteCompte(2, "John", 1000, -100);
                string infoBanqueCm = cm.ToString();

                Compte? compteInfo1 = cm.RendCompte(3); // null
                Compte? compteInfo2 = cm.RendCompte(2); // John

                Banque ca = new Banque("Crédit Agricole", "Mulhouse");
                ca.AjouteCompte(1245, "Robert", 2000, -300);
                ca.AjouteCompte(2568, "Denis", 1000, -300);
                string infoBanqueCa = ca.ToString();    

                bool transfert01 = ca.Transferer(1245, 2568, 1000); // true
                bool transfert02 = ca.Transferer(1245, 2568, 5000); // false
                bool transfert03 = ca.Transferer(1, 2568, 100); // false

            }
            catch (Exception e)
            {
                string result = e.Message;
            }

        }
    }
}

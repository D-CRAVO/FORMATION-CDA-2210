using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationVol_2
{
    public class program
    {
        static void Main(string[] args)
        {
            Compagnie compagnie01 = new Compagnie("Compagnie01");
            Aeroport aeroport01 = new Aeroport("Aeroport01");
            Aeroport aeroport02 = new Aeroport("Aeroport02");
            DateTime dateHeureDepart = new DateTime(2022, 12, 30, 12, 00, 00);
            DateTime dateHeureArrivee = new DateTime(2022, 12, 31, 15, 00, 00);
            Vol vol01 = new Vol(null, aeroport01, aeroport02, compagnie01, EnumVolOuvertureReservationEtat.enAttente, "0123", dateHeureDepart, dateHeureArrivee);
        }
    }
}

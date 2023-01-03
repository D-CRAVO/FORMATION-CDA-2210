using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationVol_2
{
    public class Personne
    {
        private string nom;
        private string prenom;

        public Personne(string _nom, string _prenom)
        {
            this.nom = _nom;
            this.prenom = _prenom;
        }

        public bool AnnulerReservation(Reservation _reservation)
        {
            return _reservation.AnnulerReservation();
        }

        public bool ValiderReservation(Reservation _reservation)
        {
            return _reservation.ValiderReservation();
        }
    }
}

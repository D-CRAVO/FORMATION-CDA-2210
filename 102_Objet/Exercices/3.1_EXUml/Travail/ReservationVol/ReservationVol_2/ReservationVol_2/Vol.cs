using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationVol_2
{
    public class Vol
    {
        private string volNumero;
        private EnumVolOuvertureReservationEtat volOuvertureReservationEtat;
        private Compagnie saCompagnie;
        private Aeroport sonAeroportDepart;
        private Aeroport sonAeroportArrivee;
        private Escale sonEscale;
        private DateTime dateHeureDepart;
        private DateTime dateHeureArrivee;

        public Vol(Escale _sonEscale, Aeroport _sonAeroportArrivee, Aeroport _sonAeroportDepart, Compagnie _saCompagnie, EnumVolOuvertureReservationEtat _volOuvertureReservationEtat, string _volNumero, DateTime _dateHeureDepart, DateTime _dateHeureArrivee)
        {
            this.volNumero = _volNumero;
            this.volOuvertureReservationEtat = _volOuvertureReservationEtat;
            this.saCompagnie = _saCompagnie;
            this.sonAeroportDepart = _sonAeroportDepart;
            this.sonAeroportArrivee = _sonAeroportArrivee;
            this.sonEscale = _sonEscale;
            this.dateHeureDepart = _dateHeureDepart;
            this.dateHeureArrivee = _dateHeureArrivee;
        }

        public bool OuvrirReservation()
        {
            if(volOuvertureReservationEtat == EnumVolOuvertureReservationEtat.enAttente)
            {
                volOuvertureReservationEtat = EnumVolOuvertureReservationEtat.ouverte;
                return true;
            }
            return false;
        }

        public bool FermerReservation()
        {
            if(volOuvertureReservationEtat == EnumVolOuvertureReservationEtat.ouverte)
            {
                volOuvertureReservationEtat = EnumVolOuvertureReservationEtat.fermee;
            }
            return true;
        }
    }
}

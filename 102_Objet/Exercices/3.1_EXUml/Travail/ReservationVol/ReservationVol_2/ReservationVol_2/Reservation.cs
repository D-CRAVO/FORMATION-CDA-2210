using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationVol_2
{
    public class Reservation
    {
        private string reservationNumero;
        private Client client;
        private Passager passager;
        private Vol vol;
        private Compagnie compagnie;
        private EnumReservationEtat reservationEtat;

        public Reservation(string _reservationNumero, Client _client, Passager _passager, Vol _vol, Compagnie _compagnie, EnumReservationEtat _reservationEtat)
        {
            this.reservationNumero = _reservationNumero;
            this.client = _client;
            this.passager = _passager;
            this.vol = _vol;
            this.compagnie = _compagnie;
            this.reservationEtat = _reservationEtat;
        }

        public bool ValiderReservation()
        {
            if (reservationEtat == EnumReservationEtat.enAttente)
            {
                reservationEtat = EnumReservationEtat.validee;
                return true;
            }
            return false;
        }

        public bool AnnulerReservation()
        {
            if(reservationEtat == EnumReservationEtat.enAttente)
            {
                reservationEtat = EnumReservationEtat.annulee;
                return true;
            }
            return false;
        }
    }
}

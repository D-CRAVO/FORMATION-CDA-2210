using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationVol_2
{
    public class Escale
    {
        private DateTime escaleHeureArrivee;
        private DateTime escaleHeureDepart;
        private Aeroport sonAeroport;

        public Escale(DateTime _escaleHeureArrivee, DateTime _escaleHeureDepart, Aeroport _sonAeroport)
        {
            this.escaleHeureArrivee = _escaleHeureArrivee;
            this.escaleHeureDepart = _escaleHeureDepart;
            this.sonAeroport = _sonAeroport;
        }
    }
}

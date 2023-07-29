using CLNavigateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLObservateur
{
    public interface IAffichage
    {
        public abstract void Affichage(Satellite _satellite);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLNavigateur
{
    internal interface ISujet
    {
        public abstract void AjouterObservateur(IObservateur _observateur);
        public abstract void SupprimerObservateur(IObservateur _observateur);
        public abstract void NotifierObservateur();
    }
}

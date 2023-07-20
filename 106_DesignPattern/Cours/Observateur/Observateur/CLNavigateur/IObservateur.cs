using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CLNavigateur
{
    public interface IObservateur
    {
        public abstract void Actualiser(Satellite _satellite);
    }
}

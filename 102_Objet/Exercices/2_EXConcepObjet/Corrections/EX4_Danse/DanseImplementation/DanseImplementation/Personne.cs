using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanseImplementation
{
    public abstract class Personne
    {
        public uint age;

        public void DanserDisco() { }

        public virtual void Marcher() { }

        public abstract void DanserSalon();
    }
}

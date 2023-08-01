using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLElementsChimiques
{
    public class CorpsCompose : Element
    {
        private Element element1;
        private Element element2;
        
        public CorpsCompose (Element element1, Element element2, string nom) : base (nom) 
        { 
            this.element1 = element1;
            this.element2 = element2;
        }

        public override void Associer()
        {
            throw new NotImplementedException();
        }
    }
}

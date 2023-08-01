using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLElementsChimiques
{
    public class CorpsSimple : Element
    {
        private Element element;

        public CorpsSimple(Element element, string nom) : base(nom)
        {
            this.element = element;
        }

        public override void Associer()
        {
            throw new NotImplementedException();
        }
    }
}

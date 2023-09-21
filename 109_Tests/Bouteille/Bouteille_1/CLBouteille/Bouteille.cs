using Bouteille_1.ExceptionsBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille_1
{
    public class Bouteille
    {
        public bool Ouvert { get; set; }
        public float Contenance { get; set; }
        public float Contenu { get; set; }

        public Bouteille(float _contenance, float _contenu, bool _ouvert) 
        {
            this.Contenance = _contenance;
            if (_contenu > _contenance)
                throw new ExceptionValeurContenuIncorrecte();
            this.Contenu = _contenu;
            this.Ouvert = _ouvert;
        }

        public bool Ouvrir()
        {
            if (!Ouvert)
            {
                Ouvert = true;
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}

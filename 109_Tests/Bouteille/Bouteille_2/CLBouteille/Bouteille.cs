using CLBouteille.ExceptionsBouteille;

namespace CLBouteille
{
    public class Bouteille
    {
        public bool Ouvert { get; set; }
        public float Contenance { get; set; }
        public float Contenu { get; set; }

        public Bouteille(float _contenance, float _contenu, bool _ouvert)
        {
            if (_contenance < 0)
                throw new ExceptionValeurContenanceIncorrecte();
            this.Contenance = _contenance;
            if (_contenu > _contenance || _contenu < 0)
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
           return false;
        }

        public bool Fermer()
        {
            if (Ouvert)
            {
                Ouvert = false;
                return true;
            }
            return false;
        }

        public bool Remplir(float v)
        {
            if (Contenu + v < Contenance)
            {
                Contenu += v;
                return true;
            }
            return false;
        }
    }
}
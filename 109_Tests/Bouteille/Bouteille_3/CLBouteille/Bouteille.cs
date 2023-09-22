using CLBouteille.ExceptionsBouteille;
using System.Reflection.Metadata.Ecma335;

namespace CLBouteille
{
    public class Bouteille
    {
        private float contenanceEnL;
        private float contenuEnL;
        private bool ouvert;

        public float ContenanceEnL 
        { 
            get { return contenanceEnL; } 
            private set 
            { 
                if (value > 0) 
                { 
                    contenanceEnL = value; 
                } 
                else 
                { 
                    throw new ContenanceValeurNegativeOuZeroException(); 
                } 
            } 
        }

        public float ContenuEnL
        {
            get { return contenuEnL; }
            private set
            {
                if (value > 0)
                {
                    contenuEnL = value;
                }
                else
                {
                    throw new ContenuValeurNegativeException();
                }
            }
        }

        public bool Ouvert
        {
            get { return ouvert; }
            private set { ouvert = value; }
        }

        public Bouteille(float _contenanceEnL, float _contenuEnL, bool _ouvert)
        {
            if (_contenanceEnL <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ContenanceEnL),"La contenance doit être superieur à zéro");
            }
            if (_contenuEnL > _contenanceEnL)
                throw new ContenuSuperieurContenanceException();
            this.ContenanceEnL = _contenanceEnL;
            this.ContenuEnL = _contenuEnL;
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

        public bool Remplir(float volumeAAjouterEnL)
        {
            if (volumeAAjouterEnL < 0)
                throw new ArgumentValeurNegativeException("Volume à ajouter en L");

            if (Ouvert)
            {
                if (ContenuEnL + volumeAAjouterEnL < ContenanceEnL)
                {
                    ContenuEnL += volumeAAjouterEnL;
                    return true;
                }
                else if (ContenuEnL + volumeAAjouterEnL > ContenanceEnL)
                {
                    ContenuEnL = ContenanceEnL;
                }
            }
            return false;
        }

        public bool Vider(float volumeAViderEnL)
        {
            if (volumeAViderEnL < 0)
                throw new ArgumentValeurNegativeException("Volume à vider en L");

            if (Ouvert)
            {
                if (volumeAViderEnL > ContenuEnL)
                {
                    ContenuEnL = 0;
                    return true;
                }
                else if (volumeAViderEnL <= ContenuEnL)
                {
                    ContenuEnL -= volumeAViderEnL;
                    return true;
                }
            }
            return false;
        }
    }
}
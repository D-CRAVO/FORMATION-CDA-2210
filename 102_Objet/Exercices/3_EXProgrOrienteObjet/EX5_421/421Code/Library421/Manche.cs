using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Manche
    {
        /// <summary>
        /// Nombre de lancés effectués pour la manche
        /// </summary>
        private byte nbLancesEffectues;
        /// <summary>
        /// Nombre de lancés maximums pour la manche
        /// </summary>
        private const byte nbLancesMax = 3;
        /// <summary>
        /// Tableau rassemblant les 3 dés du lancé
        /// </summary>
        private De?[] mesDes;

        /// <summary>
        /// Accesseur de mesDes
        /// </summary>
        public De?[] MesDes
        {
            get { return mesDes; }
        }

        /// <summary>
        /// Accesseur modifieur du nombre de lancés effectués
        /// </summary>
        public byte NbLancesEffectues
        {
            get { return nbLancesEffectues; }
            set { nbLancesEffectues = value; }
        }

        /// <summary>
        /// Constructeur par défaut de manche
        /// </summary>
        public Manche()
        {
            nbLancesEffectues = 1;
            mesDes = new De?[] { new De(), new De(), new De() };
        }

        /// <summary>
        /// Détermine s'il reste encore un lancé dans la manche
        /// </summary>
        /// <returns>
        /// True s'il reste encore un lancé à la manche
        /// False dans le cas contraire
        /// </returns>
        public bool AEncoreUnLance()
        {
            if (nbLancesEffectues < nbLancesMax)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Détermine si la manche est gagnée
        /// </summary>
        /// <returns>
        /// True si la manche est gagnée
        /// False dans le cas contraire
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool EstGagnee()
        {
            TrierDes();
            if (mesDes[0] == null || mesDes[1] == null || mesDes[2] == null)
            {
                throw new Exception("Veuillez lancer tous les dés");
            }
            else if (mesDes[0].Valeur == 4  && mesDes[1].Valeur == 2 && mesDes[2].Valeur == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Effectue le premier lancé de la manche
        /// </summary>
        //public void PremierLance()
        //{
        //    mesDes[0] = new De();
        //    mesDes[1] = new De();
        //    mesDes[2] = new De();
        //    nbLancesEffectues++;
        //}

        /// <summary>
        /// Relance les dés non égaux à 4 2 1
        /// </summary>
        public void Relance()
        {
            if (AEncoreUnLance())
            {
                int i = 0;
                while (i < nbLancesMax)
                {
                    if ((i < nbLancesMax - 1) && (MesDes[i].Valeur == 4 || MesDes[i].Valeur == 2 || MesDes[i].Valeur == 1) && (MesDes[i].Valeur == mesDes[i + 1].Valeur))
                    {
                        RelanceDe(MesDes[i]);
                        i = i+2;
                    }
                    else if (MesDes[i].Valeur != 4 && MesDes[i].Valeur != 2 && MesDes[i].Valeur != 1)
                    {
                        RelanceDe(MesDes[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                NbLancesEffectues++;
            }
        }

        public void RelanceDe(De _de)
        {
            _de.Rouler();
        }

        public void TrierDes()
        {
            Array.Sort(mesDes);
            Array.Reverse(mesDes);
        }
    }
}

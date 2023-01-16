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
        private byte nbLanceEffectue;
        /// <summary>
        /// Nombre de lancés maximums pour la manche
        /// </summary>
        private const byte nbLanceMax = 3;
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
        public byte NbLanceEffectue
        {
            get { return nbLanceEffectue; }
            set { nbLanceEffectue = value; }
        }

        /// <summary>
        /// Constructeur par défaut de manche
        /// </summary>
        public Manche()
        {
            nbLanceEffectue = 0;
            mesDes = new De?[] { null, null, null };
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
            if (nbLanceEffectue < nbLanceMax)
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
        public bool EstGagne()
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
        public void PremierLance()
        {
            mesDes[0] = new De();
            mesDes[1] = new De();
            mesDes[2] = new De();
            nbLanceEffectue++;
        }

        /// <summary>
        /// Relance les dés non égaux à 4 2 1
        /// </summary>
        public void Relance()
        {
            if (AEncoreUnLance())
            {
                for (int i = 0; i < 3; i++)
                {
                    if (MesDes[i])
                    if (MesDes[i].Valeur != 4 && MesDes[i].Valeur != 2 && MesDes[i].Valeur != 1)
                    {
                        RelanceDe(MesDes[i]);
                    }
                }
                NbLanceEffectue++;
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

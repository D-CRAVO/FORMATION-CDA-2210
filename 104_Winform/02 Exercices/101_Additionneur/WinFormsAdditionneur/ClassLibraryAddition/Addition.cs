using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddition
{
    public class Addition
    {
        /// <summary>
        /// Liste contenant l'ensemble des chiffres saisis
        /// </summary>
        private List<int> numbers;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Addition()
        {
            numbers = new List<int>();
        }

        /// <summary>
        /// Enregistre les valeurs passées en paramètre dans la liste numbers
        /// </summary>
        /// <param name="nb"></param>
        public void enregistrer(int nb)
        {
            numbers.Add(nb);
        }

        /// <summary>
        /// Additionne l'ensemble des valeurs de la liste numbers
        /// </summary>
        /// <returns>La somme obtenue</returns>
        public int getResultat()
        {
            int somme = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                somme += numbers[i];
            }
            return somme;
        }
    }
}

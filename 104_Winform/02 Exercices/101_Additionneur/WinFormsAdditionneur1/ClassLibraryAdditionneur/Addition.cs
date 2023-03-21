using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAdditionneur
{
    public class Addition
    {
        public List<Int32> numbers;
 
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Addition()
        {
            this.numbers = new List<Int32>();
        }

        /// <summary>
        /// Enregistre la valeur en paramètre dans la liste numbers.
        /// </summary>
        /// <param name="nb"></param>
        public void Enregister(Int32 nb)
        {
            this.numbers.Add(nb);
        }

        /// <summary>
        /// Additionne l'ensemble des valeurs de la liste numbers.
        /// </summary>
        /// <returns>La somme de toutes les valeurs</returns>
        public Int32 GetResultat()
        {
            int sum = 0; ;
            for (int i = 0; i < this.numbers.Count; i++)
                sum += numbers[i];
            return sum;
        }
    }
}

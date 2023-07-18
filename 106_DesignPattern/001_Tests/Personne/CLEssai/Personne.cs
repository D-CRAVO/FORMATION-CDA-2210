using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEssai
{
    public class Personne : IParlable, IEcoutable, IComparable
    {
        private int age;
        private string name;
        public int Age { get { return age; } }
        public string Name { get { return name; } }
        public Personne(int _age, string _name) 
        {
            this.age = _age;
            this.name = _name;
        }

        public int CompareTo(object? obj) 
        {
            Personne personne = obj as Personne;
            if (personne == null)
            {
                throw new System.ArgumentException();
            }
            return age.CompareTo(personne.age);
        }

        public void ecouter()
        {
            Console.WriteLine("J'écoute");
        }

        public void parler()
        {
            Console.WriteLine("Je parle");
        }
    }
}

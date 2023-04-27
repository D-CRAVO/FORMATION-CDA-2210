using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSpa
{
    public class Cat
    {
        private long puce;
        private string name;
        private int? age;
        private int race;

        public long Puce { get { return puce; } }
        public string Name { get { return name; } set { name = value; } }
        public int? Age { get {  return age; } set { age = value; } }
        public int Race { get { return race; } set { race = value; } }

        public Cat(long _puce, string _name, int? _age, int _race) 
        {
            puce = _puce;
            name = _name;
            age = _age;
            race = _race;
        }

        //public enum EnumRace
        //{
        //    Abyssin = 1,
        //    Europeen = 2,
        //    MaineCoon = 3,
        //    Sphynx = 4
        //}
    }
}

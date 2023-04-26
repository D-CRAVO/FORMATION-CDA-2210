using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLSpa
{
    public class Chat
    {
        private long puce;
        private string nom;
        private int? age;
        private EnumRace race;

        public Int64 Puce { get { return puce; } }
        public string Nom { get {  return nom; } set { nom = value; } }
        public int? Age { get { return age; } set {  age = value; } }
        public EnumRace Race { get { return race; } set { race = value; } }

        public Chat(long _puce, string _nom, int? _age, EnumRace _race) 
        { 
            puce = _puce;
            nom = _nom;
            age = _age;
            race = _race;
        }
    }
}

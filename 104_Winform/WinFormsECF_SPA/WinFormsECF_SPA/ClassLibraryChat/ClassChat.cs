using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ClassLibraryChat
{
    public class ClassChat
    {
        Int64 puceNumber;
        public Int64 PuceNumber { get => puceNumber; set => puceNumber = value; }
        string name;
        public string Name { get => name; set => name = value; }   
        int? age;
        public int? Age { get => age; set => age = value; }
        int? race;
        public int? Race { get => race; set => race = value; }

        public ClassChat(Int64 _puceNumber, string _name, int? _age, int? _race)
        {
            puceNumber = _puceNumber;
            name = _name;
            age = _age;
            race = _race;
        }
        public void CheckAge(int value)
        {
            if (value > 0 && value < 500)
            {
                age = value;
            }
            else
            {
                age = 0;
            }
        }
        /// <summary>
        /// Constructeur classic
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_age"></param>
        public ClassChat(string _name, int? _age, int? _Race)
        {
            name = _name;
            age = _age;
            Race = _Race;
        }
        /// <summary>
        /// Constructeur classic
        /// </summary>
        /// <param name="_puceNumber"></param>
        public ClassChat(Int64 _puceNumber)
        {
            puceNumber = _puceNumber;
        }
    }
}


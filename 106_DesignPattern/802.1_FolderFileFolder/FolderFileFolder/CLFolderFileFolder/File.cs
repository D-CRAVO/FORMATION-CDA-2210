using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFolderFileFolder
{
    public class File : Component
    {
        public File(string name) : base(name)
        {
            
        }

        public override void Display()
        {
            Console.WriteLine($"Fichier {Name}");
        }
    }
}

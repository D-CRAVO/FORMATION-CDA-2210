using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFileFolder
{
    public class File : Component
    {
        private string content;

        public string Content { get { return content; } }

        public File (string name, string content) : base (name)
        {
            this.content = content;
        }
        public override int Size()
        {
            return content.Length;
        }
    }
}

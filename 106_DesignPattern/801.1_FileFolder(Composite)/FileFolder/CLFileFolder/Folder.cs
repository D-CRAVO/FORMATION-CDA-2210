using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFileFolder
{
    public class Folder : Component
    {

        private List<Component> components;
        private int totalSize;
        public Folder(string name) : base(name)
        {
            components = new List<Component>();
        }

        public override int Size()
        {
            totalSize = 0;
            foreach (Component component in components)
            {
                totalSize += component.Size();
            }
            return totalSize;
        }

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}

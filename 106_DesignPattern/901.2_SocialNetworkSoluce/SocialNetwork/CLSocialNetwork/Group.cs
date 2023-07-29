using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    internal class Group : ISocialEntity
    {
        private List<ISocialEntity> members = new List<ISocialEntity>();
        public string Name { get; set; }
        public string Description { get; set; }

        public Group(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Add(ISocialEntity entity)
        {
            members.Add(entity);
        }

        public void Remove(ISocialEntity entity)
        {
            members.Remove(entity);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var member in members)
            {
                member.Display(depth + 2);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    public class GroupIterator : IEnumerator<User>
    {
        private Group group;
        private int currentIndex = -1;

        public GroupIterator(Group group)
        { 
            this.group = group; 
        }

        public User Current => group[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < group.GetMembersCount();
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}

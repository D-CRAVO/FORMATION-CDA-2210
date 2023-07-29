using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    public interface ISocialEntity
    {
        void Add(User user);
        void Remove(User user);
        void Display();
    }
}


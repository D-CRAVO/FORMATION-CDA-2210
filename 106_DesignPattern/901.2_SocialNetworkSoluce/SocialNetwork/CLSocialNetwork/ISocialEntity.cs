using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    public interface ISocialEntity
    {
        void Add(ISocialEntity entity);
        void Remove(ISocialEntity entity);
        void Display(int depth);
    }
}


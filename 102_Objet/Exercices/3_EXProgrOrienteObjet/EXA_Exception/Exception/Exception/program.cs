using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class program
    {
        static void Main(string[] args)
        {
            int[] testException = new int[5];
            testException[6] += 1;
        }
    }
}

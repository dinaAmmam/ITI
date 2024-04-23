using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap4
{
    internal class fib : iseries
    {
        int current = 1;
        int prev = 0;
        public int update()
        {
            int x = current;
            current = current + prev;
            prev = x;       
            return x;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap4
{
    internal class even: iseries
    {
        int current = 0;
        public int update()
        {
            int x = current;
            current += 2;
            return x;
        }

    }
}

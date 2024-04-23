using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap4
{
    internal class odd : iseries
    {
        int current = 1;
        public int update()
        {
            int x = current;
            current += 2;
            return x;
        }
    }
}

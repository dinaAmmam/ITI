using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class oddSeries
    {
        int current = 1;
        public int update()
        {
            int x = current;
            current += 2;
            return x;
        }
    }

    class evenSeries
    {
        int current = 0;
        public int update()
        {
            int x = current;
            current += 2;
            return x;
        }
    }
    class FibonanciiSeries
    {
        int current = 1;
        int pre = 0;
        public int update()
        {
            int x = pre + current;
            pre = current;
            current = x;


            return x;
        }
    }
}

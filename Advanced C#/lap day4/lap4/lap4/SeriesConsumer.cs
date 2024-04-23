using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap4
{
    internal class SeriesConsumer
    {
        public iseries o1 { get; set; }
        public void PrintNextNumber()
        {
            Console.WriteLine(o1.update());
        }
    }
}

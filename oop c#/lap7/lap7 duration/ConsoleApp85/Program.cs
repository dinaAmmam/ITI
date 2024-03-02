using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    class Program
    {


        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            D1.print();
            Duration D2 = new Duration(3600);
            D2.print();
            Duration D3 = new Duration(7800);
            D3.print();
            Duration D4 = new Duration(666);
            D4.print();
            Duration D5 = new Duration(1, 10, 15);
            //sumDuration(D1, D5).print();
            Duration D6 = D1 + D2;
            D6.print();
            Duration D7 = D1 + 7800;
            D7.print();
            if(D1 > D2) Console.WriteLine("d1 bigger");
            if (D1 < D2) Console.WriteLine("d2 bigger");

        }
    }
}

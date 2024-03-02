using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticate
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "dina","_dina","123jn","dina@");
            s1.print();
            Console.WriteLine();
            Authentication a1 = new Authentication(s1);
            Console.WriteLine(a1.Forgetpass("_dina"));
            
            
        }
    }
}

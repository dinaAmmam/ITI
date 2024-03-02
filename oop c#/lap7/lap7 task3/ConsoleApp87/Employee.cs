using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    abstract class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public float salary { get; set; }
        public Client[] clients { get; set; }
        public abstract void ShowEmployeeDetails();

    }
}

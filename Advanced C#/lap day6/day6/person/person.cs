using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    internal class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return $" id :{id} , name:{name}, age:{age}";
        }
    }
}

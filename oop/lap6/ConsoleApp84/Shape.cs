using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Shape
    {
        //fields
        string color;
        //constructors
        //default
        public Shape()
        {
            color = "white";
        }
        public Shape(string _color)
        {
            color = _color;
        }
        // properties
        public string Color { set { color = value; } get { return color; } }
        //methods 
        public void draw()
        {
            Console.WriteLine("drawwwwww");
        }
        public float CalcArea()
        {
            return 0.0f;
        }

    }
}

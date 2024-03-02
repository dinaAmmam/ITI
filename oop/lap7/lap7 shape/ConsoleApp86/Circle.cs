using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    class Circle : Shape
    {
        //fields
        float radius;
        //constructor
        //default
        public Circle()
        {
            radius = 5.0f;
        }
        public Circle(float _radius)
        {
            radius = _radius;
        }
        //property 
        public float Radius
        {
            get { return radius; }

            set { radius = value; }
        }
        //method
        public override float CalcArea()
        {
            float area = radius * radius * 3.14f;
            return area;
        }

    }
}

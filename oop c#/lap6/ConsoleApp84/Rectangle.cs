using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Rectangle : Shape
    {
        //fields
        float dim1;
        float dim2;
        //constructor
        //default
        public Rectangle()
        {
            dim1 = 2.0f;
            dim2 = 10.0f;
        }
        public Rectangle(float _dim1 , float _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public  Rectangle (float _dim1):this(_dim1 ,10.0f)
        {
            dim1 = _dim1;
        }
        //properties
        public float Dim1
        {
            get { return dim1; }
            set { dim1 = value; }
        }
        public float Dim2
        {
            get { return dim2; }
            set { dim2 = value; }
        }
        //method
        public new float CalcArea()
        {
            float area = dim1 * dim2;
            return area;
        }
        
    }
}

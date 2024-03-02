using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Triangle:Shape
    {
        //fields
            float dim1;
            float dim2;
            float dim3;
        // constructor
        public Triangle()
        {
            dim1 = 10.0f;
            dim2 = 5.0f;
            dim3 = 15.0f;
        }
        public Triangle(float _dim1, float _dim2, float _dim3)
        {
            dim1 = _dim1;
            dim2 = _dim2;
            dim3 = _dim3;
        }
        public Triangle(float _dim1):this(_dim1, 5.0f, 15.0f)
        {

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
        public float Dim3
        {
            get { return dim3; }
            set { dim3 = value; }
        }
        public new float CalcArea()
        {
            float area = dim1 + dim2 + dim3;
            return area;
        }
    }
}

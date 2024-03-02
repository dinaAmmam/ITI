using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    class Program
    {
        public static void RunAllDraw(Shape[] _shapes)
        {
            for (int i = 0; i < _shapes.Length; i++)
            {
                _shapes[i].draw();
            }
        }
        public static float CalcuteAllAreas(Shape[] _shapes)
        {
            float result = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                //if (_shapes[i].GetType() == typeof(Circle))
                //{
                //    result += ((Circle)_shapes[i]).CalcArea();
                //}
                //else if (_shapes[i].GetType() == typeof(Triangle))
                //{
                //    result += ((Triangle)_shapes[i]).CalcArea();
                //}
                //else
                //{
                //    result += ((Rectangle)_shapes[i]).CalcArea();
                //}
                result += (_shapes[i]).CalcArea();
            }
            return result;
        }
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[]
{
                new Circle (){Radius = 5.0f},
                new Circle(){Radius = 6.0f},
                new Rectangle(){Dim1 = 5.0f, Dim2= 10.0f},
                new Square(){Dim1= 5.0f, Dim2= 5.0f},
                new Triangle(){Dim1=2.0f, Dim2=4.0f, Dim3= 3.0f}
};
            Console.WriteLine(CalcuteAllAreas(shape));
            RunAllDraw(shape);
        }
    }
}

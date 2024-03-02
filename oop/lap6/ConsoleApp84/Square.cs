using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Square:Rectangle
    {
        public Square():base(2.0f, 2.0f)
        {

        }
        public Square(float _dim1) : base(_dim1, _dim1)
        {

        }
        public new float CalcArea()
        {
           return base.CalcArea();
            
        }
        
    }
}

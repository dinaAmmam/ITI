using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class complex
    {
        int real;
        int img;
        public int Real { get; set; }
        public int Img { get; set; }

        public complex()
        {
            real = 0;
            img = 0;
        }
        public complex(int _real, int _img)
        {
            real = _real;
            img = _img;
        }
        public string print()
        {
            return  $"{ToString()}";

        }
        public override string ToString()
        {
            if (img > 0)
            {
                return $"{real} + {img}i";
            }
            else if (img < 0)
            {
                return $"{real}{img}i";
            }
            else
            {
                return $"{real}";
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            complex other = (complex)obj;
            if (real == other.real && img == other.img)
            {
                return true;
            }
            else
            { return false; }
        }
        public static complex operator +(complex c1, complex c2)
        {
            return new complex(c1.real + c2.real, c1.img + c2.img);

        }
        public static complex operator -(complex c1, complex c2)
        {
            return new complex(c1.real - c2.real, c1.img - c2.img);

        }
        public static complex operator *(complex c1, complex c2)
        {
            var real = (c1.real * c2.real) - (c1.img * c2.img);
            var img = (c1.real * c2.img)- (c1.img * c2.real);
            return new complex(real, img);
        }
        public static complex operator /(complex c1, complex c2)
        {
            var m = (c2.real * c2.real) + (c2.img * c2.img);
            var nreal = ((c1.real * c2.real) + (c1.img * c2.img)) / m;
            var result = ((c1.img * c2.real) - (c1.real * c2.img)) / m;
            return new complex(nreal, result);
        }


    }
}

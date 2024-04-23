using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab4
{
    struct HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HireDate(int _day, int _month, int _year)
        {
            Day = _day; Month = _month; Year = _year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }

    enum gender
    {
        male, female
    }
}

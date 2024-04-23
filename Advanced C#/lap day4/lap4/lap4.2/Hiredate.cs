using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lap4._2
{
    internal struct Hiredate 
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Hiredate(int _day , int _month , int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public override string ToString()
        {
            return $"day = {day} , month = {month} , year ={year}";
        }


    }
}

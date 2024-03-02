using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    class Duration
    {
        //properties && fields
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        //default constructor
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        //other constructors
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }
        public Duration(int _seconds)
        {
            if (_seconds % (60*60) == 0)
            {
                Hours = (_seconds / (60 * 60));
                Minutes = 0;
                Seconds = 0;
            }
            else if ((_seconds % (60*60)) % 60 == 0)
            {
                Hours = (_seconds / (60 * 60));
                Minutes = ((_seconds % (60 * 60) /60));
                Seconds = 0;
            }
            else
            {
                Hours = (_seconds / (60 * 60));
                Minutes = (_seconds / 60);
                Seconds = (_seconds % 60);
            }
            
        }
        // print method
        public void print()
        {
            Console.WriteLine($"Hours : {Hours}, minutes:{Minutes}, second: {Seconds}");
        }
        //overloading
        public static Duration operator +(Duration _d1, Duration d2)
        {
            return new Duration()
            {
                Hours = _d1.Hours + d2.Hours,
                Minutes = _d1.Minutes + d2.Minutes,
                Seconds = _d1.Seconds + d2.Seconds
            };
        }
        public static Duration operator +(Duration _d1,int i)
        {
            return new Duration()
            {
                Hours = _d1.Hours + 7800,
                Minutes = _d1.Minutes + 7800,
                Seconds = _d1.Seconds + 7800
            };
        }
        public static bool operator > (Duration _d1, Duration _d2)
        {
            if (_d1.Hours > _d2.Hours) return true;
            else if (_d1.Hours == _d2.Hours)
            {
                if (_d1.Minutes > _d2.Minutes) return true;
                else if (_d1.Minutes == _d2.Minutes)
                {
                    if (_d1.Seconds > _d2.Seconds) return true;
                    else return false;

                }
                else return false;
            }
            else return false;
        }
        public static bool operator < (Duration _d1, Duration _d2)
        {return !(_d1 > _d2);}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    internal class HireDate
    {
        //fields
        int day;
        int month;
        int year;
        //properties
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //methods
        public void set_day(int _day)
        {
            if (_day >= 1 && _day <= 31)
            {
                day = _day;
            }
        }
        public int get_day()
        {
            return day;
        }
        public void set_month(int _month)
        {
            if (_month >= 1 && _month <= 12)
            {
                month = _month;
            }
        }
        public int get_month()
        {
            return month;
        }
        public void set_year(int _year)
        {
            if (_year >= 2010 && _year <= 2023)
            {
                year = _year;
            }
        }
        public int get_year()
        {
            return year;
        }
        //print method
        public void printd()
        {
            Console.WriteLine($"day = {day} , month = {month} , year ={year}");
        }
        public HireDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public HireDate(int _year)
        {
            day = 1;
            month = 1;
            year = _year;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class employee:IComparable 
    {

        int id;
        string name;
        float salary;
        HireDate date;
        gender g;

        public int ID
        {
            set
            { 
                if(value>0)
                    id = value; 
            }
            get
            { return id;}

        }
        public string Name {
            set {
                if (value.Trim().Length >= 3)
                    name = value; 
            }
            get { return name; }
        }
        public float Salary {
            set { if(value> 3000)
                   salary = value;
            }
            get { return salary; }
        }
        public gender Gender
        {
            set {  g = value; } 
             
                
            get { return g; }
        }
        public HireDate hireDate { 
            set { date = value; } 
            get { return date; } 
        }

        public employee(int _id, string _name, float _salary, gender _g, HireDate _date ) { 
            id = _id;
            name = _name;
            salary = _salary;
            g = _g;
            date = _date;
        }
        // sort year
        /* public int CompareTo(object obj)
         {
             if (obj == null) return 1;

             employee p = obj as employee;
             if (obj is employee)
                 return 1;
             return this.hireDate.Year.CompareTo(p.hireDate.Year);

         }*/
        // sort all date
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            employee p = obj as employee;
            if (p == null) return 1;

            int yearComparison = this.hireDate.Year.CompareTo(p.hireDate.Year);
            if (yearComparison != 0) return yearComparison;

            int monthComparison = this.hireDate.Month.CompareTo(p.hireDate.Month);
            if (monthComparison != 0) return monthComparison;

            return this.hireDate.Day.CompareTo(p.hireDate.Day);
        }  // no boxing or un boxing as hireDate is struct (value type), contain also value type
        public override string ToString() {
            return $"emp name: {name}, id: {id}, salary: {string.Format(new CultureInfo("en-US"), "{0:C}", salary)}, gender: {g}, HireDate: {date.ToString()}";
        }

    }
}

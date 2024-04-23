using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lap4._2
{
    enum gender
    {
        male, female
    }
    internal class employee : IComparable
    {
        public int Id { get; set; }
        public float Salary { get; set; }

        public gender Gender { get; set; }
        public string Name { get; set; }

        public Hiredate Hiredate { get; set; }
        public employee(int _id , float _salary , gender _gender , string _name, Hiredate _hiredate)
        {
            Id = _id;
            Salary = _salary;
            Gender = _gender;
            Name = _name;
            Hiredate = _hiredate;
        }

        public override string ToString()
        {
            return $" ID ={Id}, Gender= {Gender}, salary: { /*"{0:C}",*/ Salary} , hiredate {Hiredate.ToString()}";
            //Hiredate.ToString() ;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            employee p = obj as employee;
            if (p == null) return 1;

            int yearComparison = this.Hiredate.year.CompareTo(p.Hiredate.year);
            if (yearComparison != 0) return yearComparison;

            int monthComparison = this.Hiredate.month.CompareTo(p.Hiredate.month);
            if (monthComparison != 0) return monthComparison;

            return this.Hiredate.day.CompareTo(p.Hiredate.day);
        }
    }
}

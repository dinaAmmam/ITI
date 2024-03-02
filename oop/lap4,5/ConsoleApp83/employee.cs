using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    internal struct employee
    {
        //fields
        int id;
        string name;
        string security_level;
        float salery;
        HireDate hd;
        string gender;
        //properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Security_level
        {
            get { return security_level; }
            set { security_level = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Salery
        {
            get { return salery; }
            set { salery = value; }
        }
        public HireDate Hd
        {
            get { return hd; }
            set { hd = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        //methods
        public void set_id(int _id)
        {
            if (_id >= 1 && _id <= 30)
            {
                id = _id;
            }
        }
        public int get_id()
        {
            return id;
        }

        public void set_security(string _security)
        {
            if (_security.Trim() == "guest" || _security.Trim() == "Developer"
                || _security.Trim() == " secretary " || _security.Trim() == " DBA")
            {
                security_level = _security;
            }
            else
            {
                security_level = "not available";
            }
        }
        public string get_security()
        {
            return security_level;
        }
        public void set_salery(float _salery)
        {
            if (_salery >= 5000 && _salery <= 30000)
            {
                salery = _salery;
            }
            else
            {
                salery = 5000;
            }
        }
        public float get_salery()
        {
            return salery;
        }
        public string get_name()
        {
            return name;
        }
        public void set_name(string _name)
        {
            _name = name;
        }
        public void set_gender(string _gender)
        {
            if (_gender.Trim() == "M" || _gender.Trim() == "F")
            {
                _gender = gender;
            }
            else
            {
                _gender = "not available";
            }
        }
        public string get_gender()
        {
            return gender;
        }
        public void set_hireDate(HireDate _hd)
        {
            _hd = hd;
        }
        public HireDate get_hireDate()
        {
            return hd;
        }
        //print method
        public void print()
        {
            Console.WriteLine($"id = {id} , name = {name} , security level = {security_level} , salery ={salery} , gender ={gender} , hire date =");
            hd.printd();
        }
        //constructor
        public employee(int _id, string _name, string _security, float _salery, HireDate _hd, string _gender)
        {
            id = _id;
            security_level = _security;
            salery = _salery;
            hd = _hd;
            gender = _gender;
            name = _name;

        }

        public employee(int _id, string _name)
        {
            id = _id;
            security_level = "guest";
            salery = 5000;
            HireDate h = new HireDate(5, 10, 2019);
            hd = h;
            gender = "F";
            name = _name;

        }
    }
}

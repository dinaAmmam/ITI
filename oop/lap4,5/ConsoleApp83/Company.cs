using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    struct Company
    {
        //fields
        string companyname;
        Department[] departments;
        //properties
        public string Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }
        public Department[] Departments
        {
            get { return departments; }
            set { departments = value; }
        }
        //indexer
        public string this[ int d_id]
        {
            get
            {
                for(int i=0; i<departments.Length; i++)
                {
                    if(departments[i].DeptID == d_id)
                    {
                        return departments[i].Deptname;
                    }
                }
                return $"Department with ID {d_id} not found!!";

            }
            set
            {
                for(int i =0; i<departments.Length; i++)
                {
                    if(departments[i].DeptID == d_id)
                    {
                        departments[i].Deptname = value;
                    }
                }
                Console.WriteLine($"Department with ID {d_id} not found. Not Updated!!");
            }
        }

        //print method
        public void Print()
        {
            Console.WriteLine($"Company data: company name = {companyname}");
            Console.WriteLine("departments");
            for(int i =0; i< departments.Length; i++)
            {
                departments[i].Print();
            }
        }
        //constructor 
        public Company(string _companyname, Department[] _departments)
        {
            companyname = _companyname; departments = _departments;
        }

    }
}

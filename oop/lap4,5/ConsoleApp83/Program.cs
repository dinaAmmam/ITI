using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    internal class Program
    {
        public static employee[] FillEmployees()
        {
            employee[] employees = new employee[3];
            //Console.WriteLine("receiving employee data : ");

            int _id; string _name; string _security; float _salery; HireDate _hd; string _gender;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"employee {i + 1} data:");
                Console.WriteLine("id =");
                _id = int.Parse(Console.ReadLine());
                Console.WriteLine($"security =");
                _security = Console.ReadLine();
                Console.WriteLine($"name =");
                _name = Console.ReadLine();
                Console.WriteLine("salery =");
                _salery = float.Parse(Console.ReadLine());
                Console.WriteLine("date =");
                _hd = new HireDate(5, 10, 2019);
                Console.WriteLine("gender =");
                _gender = (Console.ReadLine());
                employees[i] = new employee(_id,_name, _security, _salery, _hd, _gender);

            }
            return employees;
        }
        //check unique id method
        public static bool CheckUniqueID(Department[] _dep, int _id)
        {
            for(int i =0; i< _dep.Length; i++)
            {
                if(_dep[i].GetID() == _id)
                {
                    return false;
                }
            }
            return true;
        }
        //check unique name method
        public static bool CheckUniqueDepName(Department[] _dep, string _name)
        {
            for (int i = 0; i < _dep.Length; i++)
            {
                if (_dep[i].GetName() == _name)
                {
                    return false;
                }
            }
            return true;
        }
        //check unique employee id method
        public static bool CheckUniqueEmpID (employee[] _emp , int _id)
        {
            for(int i =0; i<_emp.Length; i++)
            {
                if(_emp[i].get_id() == _id)
                {
                    return false;
                }
            }
            return true;
        }
        //search by name
        public static void SearchbyName(employee[] arr, string _name)
        {
            for(int i =0; i<arr.Length; i++)
            {
                if(arr[i].get_name() == _name)
                {
                    arr[i].print();
                }
            }
            Console.WriteLine("not found");
        }
        //search by id
        public static void SearchbyID(employee[] arr, int _id )
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].get_id() == _id)
                {
                    arr[i].print();
                }
            }
            Console.WriteLine("not found");
        }
        //delete by id
        public static void deletebyID(employee[] arr, int _id)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].get_id() == _id)
                {
                    arr[i].Id = 0;
                }
            }
            Console.WriteLine("not found");
        }

        //count 
        public static void count(employee[] em)
        {
            int n = em.Length;
            Console.WriteLine(n);
        }
        //update by id
        public static void updateID(employee[] arr , int _new , int _old)
        {
            for(int i =0; i< arr.Length; i++)
            {
                if (arr[i].get_id() == _old)
                {
                    arr[i].set_id(_new);
                }
            }

        }

        public static employee[] concat(employee[] em1, employee[] em2)
        {
            int newsize = em1.Length + em2.Length;
            employee[] conarr = new employee[newsize];
            for (int i = 0; i < em1.Length; i++)
            {
                conarr[i] = em1[i];
            }
            int newlength = em1.Length;
            for (int i = 0; i < em2.Length; i++)
            {
                conarr[newlength] = em2[i];
                newlength += 1;
            }
            return conarr;
        }
        public static void Printemployees(employee[] employees)
        {
            Console.WriteLine("Printing Data");
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].print();
            }
        }

        static void Main(string[] args)
        {
            //HireDate h = new HireDate(5, 10, 2019);
            //h.setday(); h.setmonth(11);
            //employee emp = new employee(1, "guest", 5500, h, "F");
            //emp.print();
            //employee[] emp1 = { new employee(1, "guest", 5500, h, "F"), new employee(1, "guest", 5500, h, "F") };
            //Department d = new Department();
            //d.GetEmployee();
            //Department dep = new Department();
            //dep.Print();
            //Company com = new Company();
            //com.Print();
            //HireDate h = new HireDate(5, 10, 2019);
            //create employees
            employee employee1 = new employee(1, "salma");
            employee employee2 = new employee(2, "merna");
            employee employee3 = new employee(3, "rana");
            employee employee4 = new employee(4, "mostafa");
            employee employee5 = new employee(5, "youssef");
            employee employee6 = new employee(6, "mohamed");
            employee employee7 = new employee(7, "mustafa");
            employee employee8 = new employee(8, "mariam");
            employee employee9 = new employee(9, "malak");
            employee employee10 = new employee(10, "menna");
            employee[] employees = new employee[] {employee1,employee10,employee2,employee3,employee4,employee5,employee8,employee6,employee7,employee9};
            //create department
            Department itdepartment = new Department("it","dina",1, new employee[] { employee1, employee2 , employee6, employee8,employee9,employee10 });
            Department hrdepartment = new Department("hr", "mohamed", 2, new employee[] { employee3, employee4, employee5,employee7 });

            //create microsoft company:
            Company microsoft = new Company("microsoft", new Department[] { itdepartment, hrdepartment });

            //print info 
            Console.WriteLine("company info");
            microsoft.Print();


            //list
            Console.WriteLine("chose letter");
            Console.WriteLine("a: insert , \n b: display \n c: search by id \n d:search by name" +
                "\n e: count employees \n f: update by id \n g: delete by id " +
                "\n h:exist ");
            Char c = char.Parse(Console.ReadLine());
            do
            {
                switch (c)
                {
                    case 'A':
                    case 'a':
                        FillEmployees();
                        break;
                    case 'b':
                    case 'B':
                        FillEmployees();
                        break;
                    case 'c':
                    case 'C':
                        SearchbyID(employees, 1);
                        break;
                    case 'd':
                    case 'D':
                        SearchbyName(employees,"mohamed");
                        break;
                    case 'e':
                    case 'E':
                        count(employees);
                        break;
                    case 'f':
                    case 'F':
                        updateID(employees,3,30);
                        break;
                    case 'G':
                    case 'g':
                        deletebyID(employees,1);
                        break;
                    case 'h':
                    case 'H':
                        Console.WriteLine("thanks for your time"); ;
                        break;
                }
                Console.ReadKey();
            } while (c != 'e' && c != 'E');


        }
    }
}

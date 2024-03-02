using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Program
    {
        public static Employee Getlen (Employee[] emp)
        {
            int max = 0;
            Employee employee = null;
            for (int i = 0; i < emp.Length; i++)
            {
                if(emp[i].clients.Length > max)
                {
                    max = emp[i].clients.Length;
                    employee = emp[i];
                }
            }
            return employee;

        }

       //public static Employee GetEmployeeWithLongestClients(Employee[] _em)
       // {

       //     foreach (Employee i in _em)
       //     {
       //         if()
       //     }
       // }
        static void Main(string[] args)
        {
            
            //nested loop  find max
            

            
            //create clients
            Client c1 = new Client(1, "omar", "mans");
            Client c2 = new Client(2, "salma", "mahalla");
            Client c3 = new Client(3, "hamo", "cairo");
            Client c4 = new Client(4, "gamila", "aswan");
            Client c5 = new Client(5, "salwa", "mans");
            //create hr,pr employees
            HREmployee h = new HREmployee(1, "dina",50000.0f,new Client[] {c1,c2,c3 });
            PREmployee p = new PREmployee(2, "menna", 1000.0f, new Client[] { c4, c5 });
            //array of employees
            Employee[] em = new Employee[] {h , p};
            Console.WriteLine("hr employee details");
            h.ShowEmployeeDetails();
            Console.WriteLine("pr employee details");
            p.ShowEmployeeDetails();



            
        }
    }
}

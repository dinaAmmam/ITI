using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class HREmployee:Employee
    {
        public HREmployee()
        {
            id = 0;
            name = "none";
            salary = 0.0f;
            clients = null;
        }
        public HREmployee(int _id, string _name , float _salary, Client[] _clients)
        {
            id = _id;
            name = _name;
            salary = _salary;
            clients = _clients;
        }
        public override void ShowEmployeeDetails()
        {
            Console.WriteLine($"hr employee details: id :{id}, name {name}, salary {salary}");
            for (int i =0; i< clients.Length; i++) 
            { clients[i].ShowClientDetails(); }
        }
    }
}

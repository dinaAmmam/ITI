using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public Client()
        {
            id = 0;
            name = "none";
            city = "none";
        }
        public Client(int _id, string _name , string _city)
        {
            id = _id;
            name = _name;
            city = _city;
        }
        public void ShowClientDetails()
        {
            Console.WriteLine($"client data: id = {id} , name = {name}, city = {city}");
        }

    }
}

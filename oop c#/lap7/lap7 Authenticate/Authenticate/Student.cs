using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticate
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string userpass { get; set; }
        public string email { get; set; }
        public Student()
        {
            id = 0;
            name = null;
            username = null;
            userpass = null;
            email = null;

        }
        public Student(int _id,string _name, string _username, string _userpass , string _email)
        {
            id = _id;
            name = _name;
            username = _username;
            userpass = _userpass;
            email = _email;
                
        }
        public void print()
        {
            Console.WriteLine($"id = {id}, name ={name}, username= {username} " +
                $",userpass ={userpass}, email= {email}");
        }
    }
}

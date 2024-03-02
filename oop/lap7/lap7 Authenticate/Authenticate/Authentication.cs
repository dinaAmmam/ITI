using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticate
{
    class Authentication
    {
        //property
        static Student std;
        public static Student Std
        {
            set { std = value; }
            get { return std; }
        }
        //constructor
        public Authentication()
        {
            std = null;
        }
        public Authentication(Student _std)
        {
            std = _std;
        }
        //login
        public static bool loginmethod(String _username, string _userpass, String _email)
        {
            if (Std.username == _username && Std.userpass == _userpass && Std.email == _email)
            {
                return true;
            }
            else { return false; }
        }
        public static bool loginmethod(String _email, String _userpass)
        {
            if (Std.email == _email && Std.username == _userpass)
            {
                return true;
            }
            else { return false; }

        }
        public static bool Loginmethod(int _id, string _userpass)
        {
            if (Std.id == _id && Std.userpass == _userpass)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Loginmethod(String _email, int _id)
        {
            if (Std.id == _id && Std.email == _email)
            {
                return true;
            }
            else { return false; }
        }
        //forget pass
        public string Forgetpass(string _username)
        {
            if (std.username == _username)
            {
                return std.userpass;
            }
            else { return "user not found !"; }
        }
        public static string Forgetpass(string _email, int _id)
        {
            if (std.email == _email && Std.id == _id)
            {
                return std.userpass;
            }
            else { return "user not found !"; }
        }
        public static string Forgetpass(int _id)
        {
            if (std.id == _id)
            {
                return std.userpass;
            }
            else { return "user not found !"; }
        }
        //reset pass
        public static string Resetpass(int _id, string _oldpassword, string _newpassword)
        {

            if (std.id == _id && std.userpass == _oldpassword)
            {
                return std.userpass = _newpassword;
            }
            else { return "user not found !"; }

        }
        public static bool Resetpass(string _email, string _oldpassword, string _newpassword)
        {
            if (std.email == _email && std.userpass == _oldpassword)
            {
                std.userpass = _newpassword;
                return true;
            }
            else { return false; }
        }
        public static bool Resetpass(int _id, string _username, string _oldpassword, string _newpassword)
        {

            if (std.id == _id && std.userpass == _username && std.userpass == _oldpassword)
            {
                std.userpass = _newpassword;
                return true;
            }
            else { return false; }
        }
    }
}

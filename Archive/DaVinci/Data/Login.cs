using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
    public class Login
    {
        //declaring all the variables needed for login
        private string username = "Guest";
        private string password;

        //generating parameterized constructor
        public Login(string username, string password)
        {
            Username = username;
            this.password = password;
        }

        //declaring properties
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        //To string method
        public override string ToString()
        {
            return "Username: " + username +
                "\nPassword: " + password;
        }
    }
}

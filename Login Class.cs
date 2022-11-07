using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782Project
{
    internal class Login_Class
    {
        private string name, password;

        public Login_Class(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}

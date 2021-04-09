using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Account
    {
        string login;
        string password;
        public string Login
        {
            get => login;
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 6)
                {
                    throw new Exception("Incorrect login");
                }
                this.login = value;
            }
        }
        public string Password
        {
            get => password;
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 6)
                {
                    throw new Exception("Incorrect login");
                }
                this.login = value;
            }
        }
        public Account(string l , string p)
        {
            Login = l;
            Password = p;
        }
    }
}

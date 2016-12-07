using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1.BO
{
    class Login
    {
        private string login;
        private string password;

        public Login(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

    }
}

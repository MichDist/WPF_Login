using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login
{
    class user
    {
        private string name;
        private string password;

        public user(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public user()
        {

        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login
{
    class user
    {
        private int id;
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

        public void setID(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return this.id;
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

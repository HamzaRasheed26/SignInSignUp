using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUpApp.BL
{
    internal class MUser
    {
        private string username;
        private string password;
        private string role;

        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public MUser(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.role = "null";
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password 
        {
            get { return password; }
            set { password = value; }
            
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}

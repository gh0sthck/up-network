using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace up_network
{
    public class User
    {
        String login;
        String password;
        String role;

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Role
        {
            get { return role; }
            set { role = value; }
        }

        public User(String u_login, String u_passwd, string role = "")
        {
            login = u_login;
            password = u_passwd;
            this.role = role;
        }
    }
}

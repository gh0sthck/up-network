using System;
using System.Collections.Generic;
using System.Text;

namespace up_network
{
    public class User
    {
        String login;
        String password;

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

        public User(String u_login, String u_passwd)
        {
            login = u_login;
            password = u_passwd;
        }
    }
}

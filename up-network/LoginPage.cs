using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class LoginPage : UserControl
    {

        User currentUser;
        List<User> users = new List<User>();
        public event Action<User>? onAuth;

        public LoginPage()
        {
            InitializeComponent();
        }

        public void LoginPage_Load(object sender, EventArgs e)
        {
            currentUser = new User("?", "?");
            // get data from db
            for (int i = 0; i < 10; i++)
            {
                users.Add(new User(
                    "testuser-"+i.ToString(), 
                    "pass"+i.ToString()
                ));
            }
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String enteredLogin = LoginLoginBox.Text.ToString();
            String enteredPassword = LoginPasswordBox.Text.ToString();
            foreach (User user in users)
            {
                if (user.Login == enteredLogin && user.Password == enteredPassword)
                {
                    MessageBox.Show("Вы вошли!");
                    onAuth?.Invoke(user);
                    return;
                }
            }
            MessageBox.Show("Неверный логин или пароль");
            return;
        }
    }
}

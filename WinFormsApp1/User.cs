using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User
    {
        public String UserName { get; }

        public String Password { get; }

        public String Theme { get; }

        public User(String userName, String password, String theme)
        {
            UserName = userName;
            Password = password;
            Theme = theme;

        }

    }
}

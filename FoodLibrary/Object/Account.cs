using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Account
    {
        public Account(string userName, string displayName, string password, int role)
        {
            UserName = userName;
            DisplayName = displayName;
            Password = password;
            Role = role;
        }

        public String UserName { get; set; }
        public String DisplayName { get; set; }
        public String Password { get; set; }
        public int? Role { get; set; }

    }
}

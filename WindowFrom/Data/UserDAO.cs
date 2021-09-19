using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFrom.Data
{
    public class UserDAO
    {
        public User user;
        public UserDAO()
        {
            user = new User() { ID = 2, UserName = "admin", PassWord = "admin", Remember = true  };
        }
            
    }
}

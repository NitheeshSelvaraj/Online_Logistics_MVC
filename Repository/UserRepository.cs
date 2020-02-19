using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity;

namespace Repository
{
    public class UserRepository
    {
        static List<User> userList = new List<User>();
        public void Add(User user)
        {
            userList.Add(user);
        }
        
    }
}

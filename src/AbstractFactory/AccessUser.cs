using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AccessUser : IUser
    {
        public bool AddUser(User user)
        {
            Console.WriteLine("access添加用户");

            return true;
        }

        public User GetUserById(int id)
        {
            Console.WriteLine("access获取用户信息");
            return new User();
        }
    }
}

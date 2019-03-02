using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlServerUser : IUser
    {
        public bool AddUser(User user)
        {
            Console.WriteLine("sqlserver添加用户");

            return true;
        }

        public User GetUserById(int id)
        {
            Console.WriteLine("sqlserver获取用户信息");
            return new User();
        }
    }
}

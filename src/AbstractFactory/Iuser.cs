using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IUser
    {
        bool AddUser(User user);
        User GetUserById(int id);
    }
}

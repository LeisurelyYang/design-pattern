using System;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IFactory factory = new AccessFactory();

            IUser user = factory.GetUserObj();

            IDepartment department = factory.GetDepartmentObj();

            user.AddUser(new User());

            user.GetUserById(1);

            department.AddDepartment(new Department());

            department.GetById(1);

            Console.ReadKey();
        }
    }
}
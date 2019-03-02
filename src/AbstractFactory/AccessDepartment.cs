using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AccessDepartment : IDepartment
    {
        public bool AddDepartment(Department department)
        {
            Console.WriteLine("Access添加部门");
            return true;
        }

        public Department GetById(int id)
        {
            Console.WriteLine("Access获取部门信息");
            return new Department();
        }
    }
}

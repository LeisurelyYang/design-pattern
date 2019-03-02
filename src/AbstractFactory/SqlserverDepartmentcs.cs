using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlserverDepartment : IDepartment
    {
        public bool AddDepartment(Department department)
        {
            Console.WriteLine("Sqlserver添加部门");
            return true;
        }

        public Department GetById(int id)
        {
            Console.WriteLine("Sqlserver获取部门信息");
            return new Department();
        }
    }

    
}

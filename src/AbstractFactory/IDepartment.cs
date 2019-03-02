using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IDepartment
    {
        bool AddDepartment(Department department);
        Department GetById(int id);
    }
}

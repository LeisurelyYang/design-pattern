using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IFactory
    {
        IUser GetUserObj();

        IDepartment GetDepartmentObj();
    }

    public class SqlserverFactory : IFactory
    {
        public IDepartment GetDepartmentObj()
        {
            return new SqlserverDepartment();
        }

        public IUser GetUserObj()
        {
            return new SqlServerUser();
        }
    }

    public class AccessFactory : IFactory
    {
        public IDepartment GetDepartmentObj()
        {
            return new AccessDepartment();
        }

        public IUser GetUserObj()
        {
            return new AccessUser();
        }
    }
}

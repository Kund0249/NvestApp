using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.Generic_Example
{
    class Department : IEqualityComparer<Department>
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public bool Equals(Department x, Department y)
        {
            if (x.DepartmentID == y.DepartmentID && x.DepartmentName.ToLower() == y.DepartmentName.ToLower())
                return true;
            return false;
        }

        public int GetHashCode(Department obj)
        {
           return (obj.DepartmentID.ToString() + obj.DepartmentName.ToLower()).GetHashCode();
        }
    }
}

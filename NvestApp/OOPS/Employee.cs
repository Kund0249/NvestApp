using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS
{
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public int Age;
        public float Salary;
        public bool IsMarried;

        public Employee()
        {
            EmployeeId = 0;
            EmployeeName = string.Empty;
            Age = 0;
            Salary = 0.0F;
            IsMarried = false;
        }
    }
}

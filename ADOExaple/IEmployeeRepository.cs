using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple
{
   public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        void Save(Employee employee);
    }
}

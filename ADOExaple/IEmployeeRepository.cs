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
        ArrayList GetEmployees();
        void Save(Employee employee);
    }
}

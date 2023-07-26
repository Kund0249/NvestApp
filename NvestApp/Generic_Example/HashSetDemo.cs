using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.Generic_Example
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            
            HashSet<Department> list = new HashSet<Department>(new Department())
            {
              new Department(){DepartmentID = 1,DepartmentName="A"},
              new Department(){DepartmentID = 2,DepartmentName="B"},
              new Department(){DepartmentID = 3,DepartmentName="C"},
              new Department(){DepartmentID = 4,DepartmentName="D"},
              new Department(){DepartmentID = 5,DepartmentName="E"},
              new Department(){DepartmentID = 5,DepartmentName="e"}
            };

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            foreach (Department item in list)
            {
                Console.WriteLine("Id : {0}  Name : {1}", item.DepartmentID, item.DepartmentName);
            }

            //string Name = "john";

            //string Name2 = "john";

            //Console.WriteLine("Name1 Hashcode : " + Name.GetHashCode());

            //Console.WriteLine("Name2 Hashcode : " + Name2.GetHashCode());
        }
    }
}

using System;
using System.Collections;

namespace NvestApp.OOPS
{
    public class EmployeeRePo
    {
        public ArrayList EmployeeList;
        public EmployeeRePo()
        {
            EmployeeList = new ArrayList();

            Employee employee1 = new Employee()
            {
                EmpId = 1,
                Age = 25,
                Name = "A",
                Gender = "Male",
                PrimaryContact = "7738320907",
                SecondaryContact = "7738320907"
            };

            Employee employee2 = new Employee()
            {
                EmpId = 2,
                Age = 28,
                Name = "B",
                Gender = "Male",
                PrimaryContact = "7738320907",
                SecondaryContact = "7738320907"
            };

            Employee employee3 = new Employee()
            {
                EmpId = 3,
                Age = 38,
                Name = "C",
                Gender = "Male",
                PrimaryContact = "7738320907",
                SecondaryContact = "7738320907"
            };

            EmployeeList.Add(employee1);
            EmployeeList.Add(employee2);
            EmployeeList.Add(employee3);
        }
        public Employee GetEmployee(int EmployeedId)
        {
            foreach (Employee emp in EmployeeList)
            {
                if (emp.EmpId == EmployeedId)
                    return emp;
            }
            return null;
            //Employee employee = new Employee()
            //{
            //    EmpId = 1,
            //    Age = 25,
            //    Name = "A",
            //    Gender = "Male",
            //    PrimaryContact = "7738320907",
            //    SecondaryContact = "7738320907"
            //};

            //return employee;
          
        }

        public Employee[] GetAllEmployees()
        {
            // Employee e1 = new Employee() { EmpId = 1, Name = "A" };
            // Employee e2 = new Employee() { EmpId = 2, Name = "B" };
            // Employee e3 = new Employee() { EmpId = 3, Name = "C" };

            //Employee[] list = new Employee[3];
            //// list[0] = e1;
            //// list[1] = e2;
            //// list[2] = e3;
           

            //list[0] = new Employee() { EmpId = 1, Name = "A" };
            //list[1] = new Employee() { EmpId = 2, Name = "B" };
            //list[2] = new Employee() { EmpId = 3, Name = "C" };

            //return list;

          

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee() { EmpId = 1, Name = "A" },
            //    new Employee() { EmpId = 2, Name = "B" },
            //    new Employee() { EmpId = 3, Name = "C" }
            //};

            //return employees;

            return new Employee[3]
            {
                new Employee() { EmpId = 1, Name = "A" },
                new Employee() { EmpId = 2, Name = "B" },
                new Employee() { EmpId = 3, Name = "John" }
            };
        }

        //public Employee Add(int V1,int V2)
        //{
        //    //int sum = 0;
        //    //return sum;
        //    Employee employee = new Employee();
        //    return employee;
        //}
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple
{
    class Program
    {
        static void Main(string[] args)
        {
          
            EmployeeRepository repository = new EmployeeRepository();

            //Employee employee = new Employee()
            //{
            //    EmpCode = 10,
            //    EmpName = "AJay",
            //    Gender = "M"
            //};

            //repository.Save(employee);
            Console.WriteLine("Data Inserted");

            //ArrayList list =  repository.GetEmployees();
            //if(list != null)
            //{
            //    Console.WriteLine("EmpCode      EmpName      Gender");
            //    foreach (Employee emp in list)
            //    {
            //        Console.WriteLine("-------------------------------");

            //        Console.WriteLine($"{emp.EmpCode}    {emp.EmpName}     {emp.Gender}");
            //    }
            //}
        }
    }
}

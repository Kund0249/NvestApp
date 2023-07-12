using System;
using System.Collections;
using NvestApp.OOPS;

namespace NvestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Num = Convert.ToInt32("10");

            //Console.WriteLine("Hii");
            ArrayList list = new ArrayList();
            list.Add(1);

            EmployeeRePo _repo = new EmployeeRePo();
            Employee employee =  _repo.GetEmployee(1);
        }
    }
}

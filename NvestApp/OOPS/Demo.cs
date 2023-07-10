using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS
{
    class Demo
    {
        static void Main(string[] args)
        {
            //int n;
            //Console.WriteLine(n);

            //Employee employee = new Employee();

            //Console.WriteLine(employee.EmployeeId);

            //employee.EmployeeId = 1;
            //employee.EmployeeName = "John";
            //employee.Salary = 10000.67F;
            //employee.Age = 24;
            //employee.IsMarried = false;

            //FuleContainer fuleContainer = new FuleContainer();
            //int Volume = fuleContainer.GetArea();

            //FuleContainer fuleContainer2 = new FuleContainer(10,10,10);
            //int Volume2 = fuleContainer2.GetArea();

            //FuleContainer fuleContainer3 = new FuleContainer(fuleContainer2);
            //int Volume3 = fuleContainer3.GetArea();


            //Console.WriteLine("Volume : " + Volume3);
            //Student S1 = new Student() { RollNo = 1, Name = "A" };
            //Student S2 = new Student() { RollNo = 2, Name = "B" };
            //Student S3 = new Student() { RollNo = 3, Name = "C" };
            //Student S4 = new Student() { RollNo = 4, Name = "D" };

            Student S1 = new Student() { Name = "A" };
            Student S2 = new Student() { Name = "B" };
            Student S3 = new Student() { Name = "C" };
            Student S4 = new Student() { Name = "D" };
            Console.WriteLine();
            Console.WriteLine("Roll " + S3.GetRoll());
            Console.WriteLine("Total Count : " + Student.Counter);
        }
    }
}

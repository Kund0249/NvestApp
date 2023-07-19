using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple
{
    class Startup
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("[New Emp-1] [Get Emp - 2] [Exit - 3]");
            Console.WriteLine("-----------------------------");
            int UserChoice;
            do
            {
                Console.Write("Select => ");
                UserChoice = Convert.ToInt32(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                        Employee employee = new Employee();
                        //employee.SetData();
                        Console.Write("Enter EmpName : ");
                        employee.EmpName = Console.ReadLine();

                        Console.Write("Enter Gender : ");
                        employee.Gender = Console.ReadLine();

                        repository.Save(employee);
                        break;
                    case 2:
                        Console.WriteLine("EmpCode      EmpName      Gender");
                        foreach (Employee emp in repository.GetEmployees())
                        {
                            Console.WriteLine("-------------------------------");

                            Console.WriteLine($"{emp.EmpCode}    {emp.EmpName}     {emp.Gender}");
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
                Console.WriteLine();
            } while (UserChoice != 3);
        }
    }
}

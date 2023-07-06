using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement
{
    class BasicCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select Operator (+ - / *) : ");
            char Op = Console.ReadKey().KeyChar;

            Console.WriteLine();
          
            if (Op == '+')
                //Console.WriteLine("Sum : {0}",(N1 + N2));
                Console.WriteLine("{0} + {1} = {2}", N1, N2, (N1 + N2));
            else if (Op == '-')
                Console.WriteLine($"Sub : {N1 - N2}");
            else if (Op == '/')
            Console.WriteLine("Div : " + (N1 / N2));
            else if (Op == '*')
                Console.WriteLine("Mul : {0}", (N1 * N2));
            else
                Console.WriteLine("Invalid Input!");

        }
    }
}

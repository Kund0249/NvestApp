using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement.IterationStatement
{
    class DoWhileLoopDemo
    {
        static void Main(string[] args)
        {
            char C;
            do
            {
                Console.Write("Enter N1 : ");
                int N1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter N2 : ");
                int N2 = Convert.ToInt32(Console.ReadLine());


                Console.Write("Select Operator (+ - / *) : ");
                char Op = Console.ReadKey().KeyChar;

                Console.WriteLine();

                switch (Op)
                {
                    case '+':
                        Console.WriteLine("{0} + {1} = {2}", N1, N2, (N1 + N2));
                        break;
                    case '-':
                        Console.WriteLine("{0} - {1} = {2}", N1, N2, (N1 - N2));
                        break;
                    case '*':
                        Console.WriteLine("{0} * {1} = {2}", N1, N2, (N1 * N2));
                        break;
                    case '/':
                        Console.WriteLine("{0} / {1} = {2}", N1, N2, (N1 / N2));
                        break;
                    default:
                        Console.WriteLine("Opps! Invalid input!");
                        break;
                }

                Console.Write("To continue press y : ");
                C = Console.ReadKey().KeyChar;
                C = char.ToLower(C);
                Console.WriteLine();

            } while (C == 'y');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement.IterationStatement
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("   *");
            //    Console.WriteLine("  ***");
            //    Console.WriteLine(" *****");
            //    Console.WriteLine("*******");

            Console.Write("Enter Number of Lines : ");
            int line = Convert.ToInt32(Console.ReadLine());

            int S = line-1;//2//1//0//-1
            int P = 1;//3//5//7//9

            for (int i = 1; i <= line; i++)
            {
                for (int j = 1; j <= S; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= P; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                S--;
                P += 2; // P = P+2;
            }
        }
    }
}

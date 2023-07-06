using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement.IterationStatement
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*");
            //Console.WriteLine("**");
            //Console.WriteLine("***");
            //Console.WriteLine("*****");

            Console.Write("Enter Number of Lines : ");
            int line = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= line; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

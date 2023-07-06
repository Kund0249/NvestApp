using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement.IterationStatement
{
    class ForLoopDemo
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 9; i+=2)
            //{
            //    Console.WriteLine("Hello");
            //}
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");

            Console.Write("Enter N : ");
            int N = Convert.ToInt32(Console.ReadLine());//5
            bool IsPrime = true;

            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    IsPrime = false;
                    break;
                    //Console.WriteLine("{0} is not a prime number",N);
                }
                //else
                //{
                //    Console.WriteLine("{0} is a prime number", N);
                //}
            }


            if (IsPrime)
                Console.WriteLine("{0} is a prime number", N);
            else
                Console.WriteLine("{0} is not a prime number", N);
        }
    }
}

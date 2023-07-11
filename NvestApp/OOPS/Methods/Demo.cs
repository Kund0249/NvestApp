using System;
using System.Collections;

namespace NvestApp.OOPS.Methods
{
    class Demo
    {
        static void Main(string[] args)
        {
            int n = 15;
            //create an instance of class
            MathUtil math = new MathUtil();

            //bool Isprime = math.IsPrime(n);

            //if (Isprime)
            //    Console.WriteLine("{0} : Prime", n);
            //else
            //    Console.WriteLine("{0} : Not Prime", n);


            //if (math.IsPrime(n))
            //    Console.WriteLine("{0} : Prime", n);
            //else
            //    Console.WriteLine("{0} : Not Prime", n);

            //int sum = math.Add(10, 20);
            //Console.WriteLine(sum);
            //math.EvenNumber(20, 10);

            int[] EvenNumbers = math.GetAllEven(1, 15);

            //foreach (int item in EvenNumbers)
            //{
            //    Console.Write(item + "\t");
            //}
            //Console.WriteLine();

            ArrayList list = math.GetEvenNumbers(1, 15);

            foreach (int item in list)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

        }
    }
}

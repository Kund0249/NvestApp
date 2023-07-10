using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ArrayProgram
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            //int N1 = 10;
            //int N2 = 20;
            ////.........
            //int N10 = 100;

            //int[] Numbers = new int[5];
            //Numbers[0] = 10;
            //Numbers[1] = 20;
            //Numbers[2] = 30;
            //Numbers[3] = 40;
            //Numbers[4] = 50;

            // int[] Numbers = new int[5] { 10, 20, 30, 40, 50 };
            //int[] Numbers = new int[] { 10, 20, 30, 40, 50 ,60};

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            int[] Numbers = new int[5];


            for (int i = 0; i < Numbers.Length; i++)
            {
                //Console.Write("Enter N{0} : ", (i + 1));
                Console.Write($"Enter N{i+1} : ");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Sum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Sum += Numbers[i];
            }
            //foreach (int n in Numbers)
            //{
            //    // Console.WriteLine(n);
            //    Sum += n;
            //}

            Console.WriteLine("Total : " + Sum);
        }
    }
}

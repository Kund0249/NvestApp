using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement.IterationStatement
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int Rev = 0; //4321
            int temp = N;
            while (N > 0)
            {
                int Rem = N % 10; //4//3//2//1
                //Console.Write(Rem);
                Rev = Rev * 10 + Rem;
                N = N / 10;//123//12//1//0
            }

           // Console.WriteLine("Rev : " + Rev);

            if(temp == Rev)
            {
                Console.WriteLine("{0} is palindrome",temp);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", temp);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement
{
    class Demo
    {
        static void Main(string[] args)
        {

            //int N1 = 11;

            //Console.WriteLine(N1%2);

            Console.Write("Enter N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            if (N1 > 0)
            {
                Console.WriteLine("{0} is +ve", N1);
            }
            else
            {
                Console.WriteLine("{0} is -ve", N1);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple.PolyMorphism
{
    class Startup
    {
        static void Main(string[] args)
        {
            MathUitility uitility = new MathUitility();

            // int[] numbers = { 10, 20, 30, 40 };
            int sum = uitility.Add(10, 20, 30, 40, 50, 60, 70);

            Console.WriteLine("Total : " + sum);
            Console.WriteLine();
        }
    }
}

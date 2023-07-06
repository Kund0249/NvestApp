using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ControlStatement.IterationStatement
{
    class WhileLoopDemo
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < length; i++)
            //{

            //}

            int N = 5;

            while (N > 0)
            {
                Console.WriteLine(N);
                N--;
            }
        }    
    }
}

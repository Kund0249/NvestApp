using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ArrayProgram
{
    class AdditionOfMatrix
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] B = new int[2, 2] { { 1, 2 }, { 3, 4 } }; ;
            //int[,] Result = new int[2,3]{{2,4},{6,8}}
            int[,] Result = new int[2, 2];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Result[row, col] = A[row, col] + B[row, col];
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(Result[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

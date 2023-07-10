using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ArrayProgram
{
    class MatrixArray
    {
        static void Main(string[] args)
        {
            // int[] ary = new int[5];
            int[,] MatrixA = new int[2, 2] { { 10, 20 }, { 20, 40 } };
            //MatrixA[0, 0] = 10;
            //MatrixA[0, 1] = 20;
            //MatrixA[1, 0] = 30;
            //MatrixA[1, 1] = 40;

            //for (int row = 0; row < 2; row++)
            //{
            //    for (int col = 0; col < 2; col++)
            //    {
            //        Console.Write("A[{0},{1}] : ", row, col);
            //        MatrixA[row, col] = Convert.ToInt32(Console.ReadLine());
            //    }

            //}

            //for (int row = 0; row < 2; row++)
            //{
            //    for (int col = 0; col < 2; col++)
            //    {
            //        Console.Write(MatrixA[row,col] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            foreach (int n in MatrixA)
            {
                Console.WriteLine(n);
            }
        }
    }
}

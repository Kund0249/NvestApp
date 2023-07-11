using System;
using System.Collections;

namespace NvestApp.OOPS.Methods
{
    class MathUtil
    {
        //access-specifiers returnType Name([arg])
        //{//body}

        public bool IsPrime(int value)
        {
            //bool IsPrime = true;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            //if (IsPrime)
            //    Console.WriteLine("{0} is prime number", value);
            //else
            //    Console.WriteLine("{0} is not prime number", value);
            //return IsPrime;
            return true;
        }

        public int Add(int V1, int V2)
        {
            //int sum = V1 + V2;
            //return sum;
            return (V1 + V2);
        }

        
        public void EvenNumber(int V1, int V2)
        {
            for (int i = (V1 < V2 ? V1 : V2); i <= (V2 > V1 ? V2 : V1); i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + "\t");
            }
            Console.WriteLine();
        }

        public int[] GetAllEven(int V1,int V2)
        {
            //Step 1 : Check how many even number is there
            int Counter = 0;
            for (int i = (V1 < V2 ? V1 : V2); i <= (V2 > V1 ? V2 : V1); i++)
            {
                if (i % 2 == 0)
                    Counter++;
            }

            //Step 2 : create array to store all even number
            int[] EvenNumbers = new int[Counter];


            //Step 3 : insert even number in array
            int Index = 0;
            for (int i = (V1 < V2 ? V1 : V2); i <= (V2 > V1 ? V2 : V1); i++)
            {
                if (i % 2 == 0)
                {
                    EvenNumbers[Index] = i;
                    Index++;
                }
                    
            }

            return EvenNumbers;
        }

        public ArrayList GetEvenNumbers(int V1, int V2)
        {
            ArrayList list = new ArrayList();
            for (int i = (V1 < V2 ? V1 : V2); i <= (V2 > V1 ? V2 : V1); i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}

using System;


namespace NvestApp.BasicProgram
{
    class Writing_Reading
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.Write("Enter Name : ");
            string StudentName = Console.ReadLine();

            Console.Write("Enter Age : ");
            int Age = int.Parse(Console.ReadLine()); // "12" =>"23"

            Console.Write("Enter Gender (M/F) : ");
            char Gender = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("Welcome " + StudentName);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Gender : " + Gender);

            //string N1 = null;
            //string N2 = null;

            //int a = int.Parse(N1); //Not able to Conver null value
            //int b = Convert.ToInt32(N2);//convert null value into 0 

            ////Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
        }
    }
}

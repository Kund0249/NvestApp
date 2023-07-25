using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.Generic_Example
{
    public class BasciCal
    {
        //public void Add(int V1,int V2)
        //{
        //    Console.WriteLine("Sum : " + (V1+V2));
        //}

        //public void Add(object V1, object V2)
        //{
        //    dynamic Value1 = V1;
        //    dynamic Value2 = V2;
        //    Console.WriteLine("Sum : " + (Value1 + Value2));
        //}

        public void Add<T>(T V1, T V2)
        {
            dynamic Value1 = V1;
            dynamic Value2 = V2;
            Console.WriteLine("Sum : " + (Value1 + Value2));
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            //BasciCal cal = new BasciCal();

            ////int n = 10;
            ////string a = 10;

            ////object ob1 = 10;
            ////object ob2 = "abc";

            //cal.Add<int>(10,20);

            //ArrayList list = new ArrayList();

            List<Department> list = new List<Department>();

            list.Add(new Department()
            {
                DepartmentID = 1,
                DepartmentName = "IT"
            });

            list.Add(
                new Department()
                {
                    DepartmentID = 2,
                    DepartmentName = "CS"
                }
                );

            foreach (Department item in list)
            {
                Console.WriteLine("Id : {0}  Name : {1}",item.DepartmentID,item.DepartmentName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS
{
    public class Student
    {
        //Instance Member
        private int RollNo;
        public string Name;
        //static Member
        public static int Counter;

        public Student()
        {
            RollNo = ++Counter;
            Name = string.Empty;
        }

        public int GetRoll()
        {
            return RollNo;
        }

        static Student()
        {
            Counter = 100;
        }
    }
}

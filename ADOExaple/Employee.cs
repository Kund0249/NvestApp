using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple
{
    class Employee
    {
        private int _EmpCode;
        private string _EmpName;
        private string _Gender;

        public int EmpCode
        {
            set { _EmpCode = value; }
            //set
            //{
            //    if (value > 0)
            //        _EmpCode = value;
            //    else
            //        throw new Exception("The value for the property EmpCode is Invalid");
            //}

            get
            {
                return _EmpCode;
            }
        }

        public string EmpName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _EmpName = value;
                else
                    throw new Exception("The value for the property EmpName is Invalid");
            }
            get
            {
                return _EmpName;
            }
        }

        public string Gender
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && (value.ToLower() == "m" || value.ToLower() == "f"))
                    _Gender = value;
                else
                    throw new Exception("The value for the property Gender is Invalid");
            }
            get
            {
                return _Gender;
            }
        }

        //public void SetEmpCode(int Value)
        //{
        //    if (Value > 0)
        //        EmpCode = Value;
        //    else
        //        throw new Exception("The value for the property EmpCode is Invalid");
        //}

        //public int GetEmpCode()
        //{
        //    return EmpCode;
        //}

        //public void SetEmpName(string Value)
        //{
        //    if (!string.IsNullOrEmpty(Value))
        //        EmpName = Value;
        //    else
        //        throw new Exception("The value for the property EmpName is Invalid");
        //}

        //public string GetEmpName()
        //{
        //    return EmpName;
        //}
        //public void SetGender(string Value)
        //{
        //    if (!string.IsNullOrEmpty(Value) && (Value.ToLower() == "m" || Value.ToLower() == "f"))
        //        Gender = Value;
        //    else
        //        throw new Exception("The value for the property Gender is Invalid");
        //}

        //public string GetGender()
        //{
        //    return Gender;
        //}

        //public void SetData()
        //{
        //    Console.Write("Employee Code : ");
        //    EmpCode = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Employee Name : ");
        //    EmpName = Console.ReadLine();

        //    Console.Write("Employee Gender : ");
        //    Gender = Console.ReadLine();
        //}
    }
}

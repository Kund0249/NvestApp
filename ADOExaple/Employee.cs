using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple
{
   public class Employee 
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

        public override string ToString()
        {
            return string.Format($"EmpCode : {EmpCode}  EmpName : {EmpName}  Gender {Gender}");
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.ExceptionHandling
{
    class CustomException : ApplicationException
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public CustomException()
        {

        }

        public CustomException(string StatusCode, string message)
        {
            this.StatusCode = StatusCode;
            StatusMessage = message;
        }
    }
}

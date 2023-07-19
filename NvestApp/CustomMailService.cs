using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp
{
    class CustomMailService : EmailService.EmailService
    {
        public override void SendMail(string From, string To, string SubjectLine, string MailBody, string MailSignature)
        {
            Console.WriteLine("Log the email");
            base.SendMail(From, To, SubjectLine, MailBody, MailSignature);
        }
    }
}

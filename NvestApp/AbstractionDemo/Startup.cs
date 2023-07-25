using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService;

namespace NvestApp.AbstractionDemo
{

    class customamailservice : EmailService.EmailService
    {
        public override void SendMail(string From, string To, string SubjectLine, string MailBody, string MailSignature)
        {
            base.SendMail(From, To, SubjectLine, MailBody, MailSignature);
        }
    }
    class Startup
    {
        static void Main(string[] args)
        {
            EmailService.EmailService service = new EmailService.EmailService();

            service.SendMail("Test@gmail.com", "test@gmail.com", "Subject", "body", "signature");
        }
    }
}

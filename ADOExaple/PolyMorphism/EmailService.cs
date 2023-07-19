using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple.PolyMorphism
{
    class EmailService
    {
        public virtual void SendMail(string From,string To,string SubjectLine,string MailBody,string MailSignature)
        {
            //logic to sent email.
            Console.WriteLine("Mail Sent");
        }

        public virtual void SendMail(string From, string To, string SubjectLine, string MailBody, string MailSignature,string[] Attachements)
        {
            //logic to sent email.
            Console.WriteLine("Mail Sent with Attachements");
        }
    }
}

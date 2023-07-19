﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple.PolyMorphism
{
    class CustomMailService : EmailService
    {
        public override void SendMail(string From, string To, string SubjectLine, string MailBody, string MailSignature)
        {
            //write your logic
            Console.WriteLine("Mail logged in DataBase");
            base.SendMail(From, To, SubjectLine, MailBody, MailSignature);
        }
    }
}

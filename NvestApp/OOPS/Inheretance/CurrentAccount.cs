using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS.Inheretance
{
    public class CurrentAccount : Account
    {
        public string OrgName { get; set; }

        public override void CreateAccount(Account account)
        {
            Console.WriteLine(account.AccountHolder);
            Console.WriteLine(account.AccountNumber);
           
        }
    }
}

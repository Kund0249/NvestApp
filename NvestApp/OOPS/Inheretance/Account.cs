using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS.Inheretance
{
    abstract public class Account
    {
        public string AccountNumber;
        public string AccountHolder;

        public abstract void CreateAccount(Account account);
    }
}

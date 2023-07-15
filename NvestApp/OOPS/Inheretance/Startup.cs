using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS.Inheretance
{
    class Startup
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount()
            {
                AccountNumber = "",
                AccountHolder = "",
                ROI = 3.5F
            };

            CurrentAccount currentAccount = new CurrentAccount()
            {
                AccountHolder = "",
                AccountNumber = "",
                OrgName = "abc pvt ltd"
            };

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystem
{
    public class Transaction
    {
        public void Process(string accountNumber, string recipientAccount, decimal amount)
        {
            Console.WriteLine($"Processing transfer of {amount:C} from {accountNumber} to {recipientAccount}.");
        }
    }
}

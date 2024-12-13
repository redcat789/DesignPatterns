using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystem
{
    public class Account
    {
        public decimal GetBalance(string accountNumber)
        {
            Console.WriteLine("Fetching account balance...");
            return 1000m; // Dummy balance
        }

        public void DeductBalance(string accountNumber, decimal amount)
        {
            Console.WriteLine($"Deducting {amount:C} from account {accountNumber}.");
        }
    }
}

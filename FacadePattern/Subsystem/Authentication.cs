using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystem
{
    public class Authentication
    {
        public bool AuthenticateUser(string accountNumber, string password)
        {
            Console.WriteLine("Authenticating user...");
            // Dummy authentication
            return accountNumber == "12345" && password == "password";
        }
    }
}

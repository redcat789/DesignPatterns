using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystem
{
    public class Notification
    {
        public void SendNotification(string accountNumber, string message)
        {
            Console.WriteLine($"Sending notification to account {accountNumber}: {message}");
        }
    }
}

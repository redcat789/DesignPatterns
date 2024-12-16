using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.RequestHandlers
{
    public class BillingSupportHandler : HelpDeskHandler
    {
        public override void HandleRequest(string issue)
        {
            if (issue.Contains("billing"))
            {
                Console.WriteLine("Billing Support: Handling the request.");
            }
            else
            {
                NextHandler?.HandleRequest(issue);
            }
        }
    }

}

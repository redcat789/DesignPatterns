using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibilityPattern.RequestHandlers;

namespace ChainOfResponsibilityPattern
{
    public class TechnicalSupportHandler : HelpDeskHandler
    {
        public override void HandleRequest(string issue)
        {
            if (issue.Contains("technical"))
            {
                Console.WriteLine("Technical Support: Handling the request.");
            }
            else
            {
                NextHandler?.HandleRequest(issue);
            }
        }
    }

}

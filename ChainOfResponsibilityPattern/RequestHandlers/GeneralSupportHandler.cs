using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.RequestHandlers
{
    public class GeneralSupportHandler : HelpDeskHandler
    {
        //Each handler specializes in handling a specific type of issue.
        public override void HandleRequest(string issue)
        {
            if (issue.Contains("general"))
            {
                Console.WriteLine("General Support: Handling the request.");
            }
            else
            {
                NextHandler?.HandleRequest(issue);
            }
        }
    }

}

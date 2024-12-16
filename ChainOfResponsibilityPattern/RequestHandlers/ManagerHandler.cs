using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.RequestHandlers
{
    public class ManagerHandler : HelpDeskHandler
    {
        public override void HandleRequest(string issue)
        {
            Console.WriteLine("Manager: Escalating and resolving the issue.");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.RequestHandlers
{
    //Defines a method to process the request and a reference to the next handler in the chain.
    public abstract class HelpDeskHandler
    {
        protected HelpDeskHandler NextHandler;

        public void SetNextHandler(HelpDeskHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void HandleRequest(string issue);
    }

}

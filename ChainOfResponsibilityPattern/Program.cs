using ChainOfResponsibilityPattern.RequestHandlers;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        /*
         * Chain of Responsibility is a behavioral design pattern that lets you pass 
         * requests along a chain of handlers. 
         * Upon receiving a request, each handler decides either to process the request 
         * or to pass it to the next handler in the chain.
         */

        /*
         * A help desk system routes user requests to the appropriate handler based on their issue.
            General Issues: Basic troubleshooting by a customer service representative.
            Billing Issues: Routed to the billing department.
            Technical Issues: Escalated to a technical support specialist.
            Unresolved Issues: Passed to a manager.
         */
        static void Main(string[] args)
        {
            // Define the chain of responsibility
            var generalSupport = new GeneralSupportHandler();
            var billingSupport = new BillingSupportHandler();
            var technicalSupport = new TechnicalSupportHandler();
            var manager = new ManagerHandler();

            generalSupport.SetNextHandler(billingSupport);
            billingSupport.SetNextHandler(technicalSupport);
            technicalSupport.SetNextHandler(manager);

            // Test the chain with different issues
            Console.WriteLine("Request 1: General inquiry");
            generalSupport.HandleRequest("general inquiry");

            Console.WriteLine("\nRequest 2: Billing issue");
            generalSupport.HandleRequest("billing issue");

            Console.WriteLine("\nRequest 3: Technical problem");
            generalSupport.HandleRequest("technical problem");

            Console.WriteLine("\nRequest 4: Complex problem");
            generalSupport.HandleRequest("complex issue");
        }
    }
}

using System;

namespace ProxyPattern
{
    class Program
    {
        /*
         * The Proxy Pattern provides a surrogate or placeholder for another object to 
         * control access to it. 
         * It is commonly used in scenarios where an object is resource-intensive to 
         * create, or access needs to be controlled for security reasons.
         */

        /*
         * A Bank ATM acts as a Proxy for the bank server.

            ATM (Proxy): Allows users to withdraw money without directly accessing the bank server.
            Bank Server (Real Subject): Processes transactions securely.
            Client: A person using the ATM.
         */
        static void Main(string[] args)
        {
            Image image = new ProxyImage("testImage.jpg");

            //image will be loaded from disk
            image.display();
            Console.WriteLine("");

            //image will not be loaded from disk
            image.display();
        }
    }
}

using System;

namespace BridgePattern
{
    public class AC : IDevice
    {
        public void StartUp()
        {
            Console.WriteLine("AC is started up");
        }

        public void Perform()
        {
            Console.WriteLine("AC is working...");
        }

        public void ShutDown()
        {
            Console.WriteLine("AC is shut down");
        }
    }
}
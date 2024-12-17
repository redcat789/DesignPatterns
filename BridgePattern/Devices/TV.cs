using System;

namespace BridgePattern.Devices
{
    public class TV : IDevice
    {
        public void StartUp()
        {
            Console.WriteLine("TV is started up");
        }

        public void Perform()
        {
            Console.WriteLine("TV is working...");
        }

        public void ShutDown()
        {
            Console.WriteLine("TV is shut down");
        }
    }
}
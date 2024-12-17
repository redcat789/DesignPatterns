using System;
using BridgePattern.Devices;

namespace BridgePattern.Remotes
{
    public class RemoteTypeB : IRemote
    {
        private readonly IDevice _device;
        public RemoteTypeB(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turning on the device by {nameof(RemoteTypeB)}");
            _device.StartUp();
            _device.Perform();
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning off the device by {nameof(RemoteTypeB)}");
            _device.ShutDown();
        }

        public IDevice GetDevice()
        {
            return _device;
        }
    }
}
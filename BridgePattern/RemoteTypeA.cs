using System;

namespace BridgePattern
{
    public class RemoteTypeA : IRemote
    {
        private readonly IDevice _device;

        public RemoteTypeA(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turning on the device by {nameof(RemoteTypeA)}");
            _device.StartUp();
            _device.Perform();
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning off the device by {nameof(RemoteTypeA)}");
            _device.ShutDown();
        }

        public IDevice GetDevice()
        {
            return _device;
        }
    }
}
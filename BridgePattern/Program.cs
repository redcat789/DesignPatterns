using BridgePattern.Devices;
using BridgePattern.Remotes;

namespace BridgePattern
{
    internal static class Program
    {
        private static void Main()
        {
            // bridge Remote TypeA + TV
            IRemote tv1 = new RemoteTypeA(new TV());
            tv1.TurnOn();
            tv1.TurnOff();
            Console.WriteLine("---------------------------");
            // bridge Remote TypeB + AC
            IRemote ac1 = new RemoteTypeB(new AC());
            ac1.TurnOn();
            ac1.TurnOff();
            Console.WriteLine("---------------------------");
            // bridge Remote TypeB + TV
            IRemote tv2 = new RemoteTypeB(new TV());
            tv2.TurnOn();
            tv2.TurnOff();
            Console.WriteLine("---------------------------");
            // bridge Remote TypeA + AC
            IRemote ac2 = new RemoteTypeA(new AC());
            ac2.TurnOn();
            ac2.TurnOff();
        }
    }
}
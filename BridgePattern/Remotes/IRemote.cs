using BridgePattern.Devices;

namespace BridgePattern.Remotes
{
    public interface IRemote
    {
        void TurnOn();
        void TurnOff();
        IDevice GetDevice();
    }
}
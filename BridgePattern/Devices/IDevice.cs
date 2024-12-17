namespace BridgePattern.Devices
{
    public interface IDevice
    {
        void StartUp();
        void Perform();
        void ShutDown();
    }
}
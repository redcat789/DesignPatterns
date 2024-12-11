namespace BridgePattern
{
    public interface IRemote
    {
        void TurnOn();
        void TurnOff();
        IDevice GetDevice();
    }
}
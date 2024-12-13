namespace MediatorPattern
{
    public interface IAirTrafficControl
    {
        void Notify(string message, Airplane sender);
    }

}
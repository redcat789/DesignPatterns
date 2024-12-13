namespace MediatorPattern
{
    public abstract class Airplane
    {
        protected IAirTrafficControl _controlTower;

        public Airplane(IAirTrafficControl controlTower)
        {
            _controlTower = controlTower;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

}
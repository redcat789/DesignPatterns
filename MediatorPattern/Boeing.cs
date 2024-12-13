namespace MediatorPattern
{
    public class Boeing : Airplane
    {
        public Boeing(IAirTrafficControl controlTower) : base(controlTower) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Boeing sends message: {message}");
            _controlTower.Notify(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Boeing receives message: {message}");
        }
    }   

}
using System;

namespace MediatorPattern
{
    public class Airbus : Airplane
    {
        public Airbus(IAirTrafficControl controlTower) : base(controlTower) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Airbus sends message: {message}");
            _controlTower.Notify(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Airbus receives message: {message}");
        }
    }
}
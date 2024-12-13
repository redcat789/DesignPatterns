using System;

namespace MediatorPattern
{
    public class AirTrafficControl : IAirTrafficControl
    {
        private readonly List<Airplane> _airplanes = new();

        public void RegisterAirplane(Airplane airplane)
        {
            _airplanes.Add(airplane);
        }

        public void Notify(string message, Airplane sender)
        {
            foreach (var airplane in _airplanes)
            {
                if (airplane != sender)
                {
                    airplane.Receive(message);
                }
            }
        }
    }

}
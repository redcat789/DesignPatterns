namespace MediatorPattern
{
    class Program
    {
        /*
         * Mediator is a behavioral design pattern that lets you reduce chaotic 
         * dependencies between objects. The pattern restricts direct communications 
         * between the objects and forces them to collaborate only via a mediator object.
         */

        /*
         * In an airport, airplanes do not communicate directly with one another to 
         * coordinate landing or takeoff. Instead, they communicate with the Air Traffic 
         * Control (ATC) tower, which acts as a mediator.

            Planes are like individual objects that need to coordinate.
            ATC is the mediator that manages the communication and ensures no collisions.
         */
        static void Main(string[] args)
        {
            // Create the mediator
            AirTrafficControl controlTower = new AirTrafficControl();

            // Create airplanes and register them
            Airplane boeing = new Boeing(controlTower);
            Airplane airbus = new Airbus(controlTower);

            controlTower.RegisterAirplane(boeing);
            controlTower.RegisterAirplane(airbus);

            // Communication via mediator
            boeing.Send("Requesting permission to land.");
            airbus.Send("Clear for takeoff.");
        }
    }
}
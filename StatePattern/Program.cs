using System;

namespace StatePattern
{
    static class Program
    {
        /*
         * The State Pattern allows an object to change its behavior when its internal 
         * state changes. It helps avoid complex if or switch statements that determine 
         * the behavior based on the object's state.
         */

        /*
         * Imagine a Traffic Light that changes its behavior based on its state:

            Red Light: Vehicles must stop.
            Yellow Light: Vehicles should prepare to stop.
            Green Light: Vehicles can go.

         */
        public static void Main()
        {
            TrafficLight trafficLight = new TrafficLight();

            // Simulate traffic light changes
            for (int i = 0; i < 6; i++) // Loop through the states multiple times
            {
                trafficLight.Change();
            }
        }       
    }
}

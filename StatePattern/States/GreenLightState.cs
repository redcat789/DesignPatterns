using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{   

    public class GreenLightState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Green Light: Vehicles can go.");
            trafficLight.SetState(new YellowLightState());
        }
    }

}

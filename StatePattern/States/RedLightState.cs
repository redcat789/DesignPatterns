using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class RedLightState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Red Light: Vehicles must stop.");
            trafficLight.SetState(new GreenLightState());
        }
    }
}

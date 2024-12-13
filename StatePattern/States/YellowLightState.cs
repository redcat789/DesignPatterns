using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class YellowLightState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow Light: Vehicles should prepare to stop.");
            trafficLight.SetState(new RedLightState());
        }
    }
}

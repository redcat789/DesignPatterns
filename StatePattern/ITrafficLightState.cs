using System;

namespace StatePattern
{
    public interface ITrafficLightState
    {
        void Handle(TrafficLight trafficLight);
    }

}
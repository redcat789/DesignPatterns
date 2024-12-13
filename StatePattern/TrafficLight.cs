using StatePattern.States;

namespace StatePattern
{
    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight()
        {
            // Default state is Red Light
            _state = new RedLightState();
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Change()
        {
            _state.Handle(this);
        }
    }

}
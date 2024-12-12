using System;

namespace ObserverPattern
{
    sealed class WeatherReceiver : IObserver<Weather>
    {
        private IDisposable _cancellation;
        private readonly string _name;

        public void Subscribe(WeatherSupplier provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }

        public WeatherReceiver(string name)
        {
            _name = name;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error has occurred");
        }

        public void OnNext(Weather value)
        {            
            Console.WriteLine($"{_name} has received: {value.Temperature}, {value.Pressure},{ value.Humidity }");
        }
    }
}

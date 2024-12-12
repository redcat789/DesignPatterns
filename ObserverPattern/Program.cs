namespace ObserverPattern
{
    static class Program
    {
        /*
         * Observer is a behavioral design pattern that lets you define a subscription 
         * mechanism to notify multiple objects about any events that happen to the 
         * object they’re observing.
         */
        static void Main()
        {
            var provider = new WeatherSupplier();
            var andy = new WeatherReceiver("Andy");
            var jack = new WeatherReceiver("Jack");

            Console.WriteLine("Weather forecast has been published...");
            provider.Notify(11, 0.05, 1.5);

            WriteLine();

            andy.Subscribe(provider);
            Console.WriteLine("andy has subscribed notification");
            Console.WriteLine("Weather forecast has been published...");
            provider.Notify(22, 0.04, 1.7);

            WriteLine();

            jack.Subscribe(provider);
            Console.WriteLine("jack has subscribed notification");
            Console.WriteLine("Weather forecast has been published...");
            provider.Notify(33, 0.07, 1.2);

            WriteLine();

            jack.Unsubscribe();
            Console.WriteLine("jack has unsubscribed notification");
            Console.WriteLine("Weather forecast has been published...");
            provider.Notify(44, 0.09, 1.8);

            WriteLine();

        }
        static void WriteLine()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }
}

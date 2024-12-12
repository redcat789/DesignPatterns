using System;

namespace DecoratorPattern
{
    static class Program
    {
        /*
         * Decorator is a structural design pattern that lets you attach new behaviors 
         * to objects by placing these objects inside special wrapper objects that 
         * contain the behaviors.
         */
        static void Main()
        {
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetDescription()} costs {myCoffee.GetCost()}");

            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} costs {myCoffee.GetCost()}");

            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} costs {myCoffee.GetCost()}");
        }
    }
}

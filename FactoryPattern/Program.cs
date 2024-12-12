using System;

namespace FactoryPattern
{
    static class Program
    {
        /*
         * Factory Method is a creational design pattern that provides an interface for 
         * creating objects in a superclass, but allows subclasses to alter the type of 
         * objects that will be created.
         */
        static void Main()
        {
            Console.WriteLine("Yankees fan orders:");
            var yankees = new NyPizzaFactory();
            yankees.Order(PizzaType.Cheese);
            Console.WriteLine();
            Console.WriteLine("Cubs fan orders:");
            var cubs = new ChicagoPizzaFactory();
            cubs.Order(PizzaType.Clam);
        }
    }
}
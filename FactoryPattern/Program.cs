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

        /*
         * 1. Factory Pattern
            Concept: A method in a class is responsible for creating objects.
            Goal: Provide an interface to create objects without specifying their exact classes.
            Key Feature: Relies on inheritance and polymorphism. Subclasses decide which object to instantiate.
            When to Use:
            When the creation process involves logic that might change over time.
            To centralize object creation and decouple the client from the implementation.
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
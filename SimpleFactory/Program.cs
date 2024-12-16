using SimpleFactory.Shapes;

namespace SimpleFactory
{
    internal class Program
    {
        /*
         * 2. Simple Factory Pattern
            Concept: A class contains a single method responsible for creating objects based on input.
            Goal: Simplify object creation when there are multiple subclasses.
            Key Feature: Uses a static method in a single class to create objects.
            When to Use:
            When the number of product types is limited and unlikely to change often.
            To centralize and simplify object creation logic.
         */
        static void Main(string[] args)
        {
            // Usage:
            var circle = ShapeFactory.CreateShape("circle");
            circle.Draw(); // Output: Drawing a Circle

            var rectangle = ShapeFactory.CreateShape("rectangle");
            rectangle.Draw(); // Output: Drawing a Rectangle
        }
    }
}

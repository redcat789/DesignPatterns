using System;

namespace PrototypePattern
{
    class Program
    {
        //Prototype is a creational design pattern that lets you copy existing objects
        //without making your code dependent on their classes.
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = (IFigure)figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = (IFigure)figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }
}

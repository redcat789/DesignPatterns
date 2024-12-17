using BuilderPattern.Builder;
using System;

namespace BuilderPattern
{
    class Program
    {
        /**
         * The Builder pattern suggests that you extract the object construction code out 
         * of its own class and move it to separate objects called builders.
         */
        static void Main()
        {
            var womanBuilder = new WomanBuilder();
            var personMaker = new Make(womanBuilder);
            var woman = personMaker.Build();

            personMaker.ChangeBuilder(new ManBuilder());
            var man = personMaker.Build();

            Console.WriteLine($"I made a woman: {woman}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"I made a man: {man}");
        }
    }
}

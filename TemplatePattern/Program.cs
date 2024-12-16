using System;
using System.Collections.Generic;

namespace TemplatePattern
{
    internal static class Program
    {
        /*
         * Template Method is a behavioral design pattern that defines the skeleton of 
         * an algorithm in the superclass but lets subclasses override specific steps of 
         * the algorithm without changing its structure.
         */
        static void Main()
        {
            var tea = new Tea();
            var coffee = new Coffee();
            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();

            Console.WriteLine();
            coffee.WantsCondiments = true;
            coffee.Prepare();            
        }
    }
}

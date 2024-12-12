using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Component: This is the class that we want to add new behavior to.
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0;
        }
    }
}

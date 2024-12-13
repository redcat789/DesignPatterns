using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Fan
    {
        public void TurnOn() => Console.WriteLine("The Fan is On.");
        public void TurnOff() => Console.WriteLine("The Fan is Off.");
    }
}

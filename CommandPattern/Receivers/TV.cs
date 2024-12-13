using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class TV
    {
        public void TurnOn() => Console.WriteLine("The TV is On.");
        public void TurnOff() => Console.WriteLine("The TV is Off.");
    }
}

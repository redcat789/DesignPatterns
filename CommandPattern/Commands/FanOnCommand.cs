using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class FanOnCommand : ICommand
    {
        private Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOn();
        }
    }
}

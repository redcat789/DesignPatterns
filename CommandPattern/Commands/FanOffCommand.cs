using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class FanOffCommand : ICommand
    {
        private Fan _fan;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOff();
        }
    }
}

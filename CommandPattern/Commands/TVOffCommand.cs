using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class TVOffCommand : ICommand
    {
        private TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOff();
        }
    }
}

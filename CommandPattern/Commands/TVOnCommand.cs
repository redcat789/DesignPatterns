using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class TVOnCommand : ICommand
    {
        private TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }
    }
}

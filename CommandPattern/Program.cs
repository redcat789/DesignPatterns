using CommandPattern.Commands;
using CommandPattern.Receivers;
using System;

namespace CommandPattern
{
    internal static class Program
    {
        /*
         * Command is a behavioral design pattern that turns a request into a stand-alone 
         * object that contains all information about the request. This transformation 
         * lets you pass requests as a method arguments, delay or queue a request’s 
         * execution, and support undoable operations.
         * 
        */
        private static void Main()
        {
            TV tv = new TV();
            Fan fan = new Fan();

            ICommand tvOn = new TVOnCommand(tv);
            ICommand tvOff = new TVOffCommand(tv);
            ICommand fanOn = new FanOnCommand(fan);
            ICommand fanOff = new FanOffCommand(fan);

            RemoteControl remote = new RemoteControl();

            // Turn on the TV
            remote.SetCommand(tvOn);
            remote.PressButton();

            // Turn off the TV
            remote.SetCommand(tvOff);
            remote.PressButton();

            // Turn on the Fan
            remote.SetCommand(fanOn);
            remote.PressButton();

            // Turn off the Fan
            remote.SetCommand(fanOff);
            remote.PressButton();
        }
    }
}
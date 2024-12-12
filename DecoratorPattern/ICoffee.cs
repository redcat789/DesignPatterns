using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Component Interface: This defines the interface for objects that can have
    //responsibilities added to them dynamically.
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}

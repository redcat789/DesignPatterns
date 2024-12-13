using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public interface ITree
    {
        void Display(int x, int y); // Extrinsic state: position
    }

}
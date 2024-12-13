using System;
using System.Collections;

namespace IteratorPattern
{
    public interface IPlaylist
    {
        IIterator<string> CreateIterator();
    }

}
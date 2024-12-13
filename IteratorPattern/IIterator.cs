using System.Collections;

namespace IteratorPattern
{
    public interface IIterator<T>
    {
        bool HasNext(); // Check if there's another item
        T Next();       // Get the next item
    }

}
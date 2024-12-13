using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface IFileSystemEntity
    {
        void Display(string indent);
        int GetSize(); // Gets the size of the entity
    }

}

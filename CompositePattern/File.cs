using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class File : IFileSystemEntity
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}File: {_name} ({_size} KB)");
        }

        public int GetSize()
        {
            return _size;
        }
    }

}

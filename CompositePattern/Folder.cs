using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Folder : IFileSystemEntity
    {
        private string _name;
        private List<IFileSystemEntity> _children = new();

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemEntity entity)
        {
            _children.Add(entity);
        }

        public void Remove(IFileSystemEntity entity)
        {
            _children.Remove(entity);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}Folder: {_name}");
            foreach (var child in _children)
            {
                child.Display(indent + "  ");
            }
        }

        public int GetSize()
        {
            int totalSize = 0;
            foreach (var child in _children)
            {
                totalSize += child.GetSize();
            }
            return totalSize;
        }
    }

}

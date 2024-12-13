using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class Forest
    {
        private readonly List<(ITree tree, int x, int y)> _trees = new();
        private readonly TreeFactory _treeFactory = new();

        public void PlantTree(string species, string color, string texture, int x, int y)
        {
            var tree = _treeFactory.GetTree(species, color, texture);
            _trees.Add((tree, x, y));
        }

        public void DisplayTrees()
        {
            foreach (var (tree, x, y) in _trees)
            {
                tree.Display(x, y);
            }
        }
    }

}
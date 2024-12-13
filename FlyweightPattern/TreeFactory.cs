using System;

namespace FlyweightPattern
{
    public class TreeFactory
    {
        private readonly Dictionary<string, Tree> _trees = new();

        public Tree GetTree(string species, string color, string texture)
        {
            string key = $"{species}_{color}_{texture}";
            if (!_trees.ContainsKey(key))
            {
                _trees[key] = new Tree(species, color, texture);
                Console.WriteLine($"Creating new tree: {key}");
            }
            return _trees[key];
        }
    }
}
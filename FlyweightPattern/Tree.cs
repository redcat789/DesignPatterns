namespace FlyweightPattern
{
    public class Tree : ITree
    {
        private readonly string _species;  // Intrinsic state
        private readonly string _color;
        private readonly string _texture;

        public Tree(string species, string color, string texture)
        {
            _species = species;
            _color = color;
            _texture = texture;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Tree ({_species}, {_color}, {_texture}) at position ({x}, {y})");
        }
    }

}
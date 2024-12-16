using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //The Originator is the Player. It creates and restores its state from the GameState (Memento).
    public class Player
    {
        public int Health { get; set; }
        public string Position { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();

        public GameState Save()
        {
            return new GameState(Health, Position, Inventory);
        }

        public void Restore(GameState gameState)
        {
            Health = gameState.Health;
            Position = gameState.Position;
            Inventory = new List<string>(gameState.Inventory); // Deep copy
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Health: {Health}, Position: {Position}, Inventory: {string.Join(", ", Inventory)}");
        }
    }
}

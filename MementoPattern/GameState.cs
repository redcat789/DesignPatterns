using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //The Memento stores the state of the player.
    public class GameState
    {
        public int Health { get; private set; }
        public string Position { get; private set; }
        public List<string> Inventory { get; private set; }

        public GameState(int health, string position, List<string> inventory)
        {
            Health = health;
            Position = position;
            Inventory = new List<string>(inventory); // Deep copy
        }
    }

}

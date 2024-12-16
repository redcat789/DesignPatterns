using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //The Caretaker manages the saved states (Mementos).
    public class SaveManager
    {
        private readonly Stack<GameState> _saveStates = new Stack<GameState>();

        public void SaveGame(GameState gameState)
        {
            _saveStates.Push(gameState);
            Console.WriteLine("Game Saved!");
        }

        public GameState LoadLastSave()
        {
            if (_saveStates.Count > 0)
            {
                Console.WriteLine("Game Loaded!");
                return _saveStates.Pop();
            }

            Console.WriteLine("No saved games available.");
            return null;
        }
    }
}

namespace MementoPattern
{
    internal class Program
    {
        /*
         * Memento is a behavioral design pattern that lets you save and restore the 
         * previous state of an object without revealing the details of its implementation.
         */

        /*
         * Imagine a video game where the player can save their progress and load it 
         * later. The player's progress includes their health, position, and inventory. 
         * Using the Memento Pattern, we can save the player's state at any point and 
         * restore it when needed.
         */
        static void Main(string[] args)
        {
            var player = new Player
            {
                Health = 100,
                Position = "Start",
                Inventory = new List<string> { "Sword", "Shield" }
            };

            var saveManager = new SaveManager();

            // Initial state
            Console.WriteLine("Initial state:");
            player.DisplayStatus();

            // Save the game
            saveManager.SaveGame(player.Save());

            // Player progresses in the game
            player.Health -= 30;
            player.Position = "Dungeon";
            player.Inventory.Add("Potion");
            Console.WriteLine("\nAfter progress:");
            player.DisplayStatus();

            // Save again
            saveManager.SaveGame(player.Save());

            // Player takes damage and loses items
            player.Health -= 50;
            player.Position = "Trap Room";
            player.Inventory.Remove("Sword");
            Console.WriteLine("\nAfter more progress:");
            player.DisplayStatus();

            // Load the last save
            Console.WriteLine("\nLoading last save...");
            var lastSave = saveManager.LoadLastSave();
            if (lastSave != null) player.Restore(lastSave);
            player.DisplayStatus();

            // Load the initial save
            Console.WriteLine("\nLoading initial save...");
            var initialSave = saveManager.LoadLastSave();
            if (initialSave != null) player.Restore(initialSave);
            player.DisplayStatus();
        }
    }
}

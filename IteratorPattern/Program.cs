namespace IteratorPattern
{
    
    static class Program
    {
        /*
         * Iterator is a behavioral design pattern that lets you traverse elements of a 
         * collection without exposing its underlying representation (list, stack, tree, etc.).
         */

        /*
         * Imagine you have a music playlist with multiple songs. The Iterator Pattern 
         * allows you to browse through these songs one by one without exposing the 
         * internal structure of the playlist.
         */
        private static void Main()
        {
            // Create a playlist
            Playlist playlist = new Playlist();
            playlist.AddSong("Song 1");
            playlist.AddSong("Song 2");
            playlist.AddSong("Song 3");

            // Create an iterator
            var iterator = playlist.CreateIterator();

            // Browse through the songs
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}

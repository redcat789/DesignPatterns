using System.Collections;

namespace IteratorPattern
{
    public class Playlist : IPlaylist
    {
        private readonly List<string> _songs = new();

        public void AddSong(string song)
        {
            _songs.Add(song);
        }

        public IIterator<string> CreateIterator()
        {
            return new PlaylistIterator(_songs);
        }
    }

}

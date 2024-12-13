using System;
using System.Collections;

namespace IteratorPattern
{
    public class PlaylistIterator : IIterator<string>
    {
        private readonly List<string> _songs;
        private int _currentIndex = 0;

        public PlaylistIterator(List<string> songs)
        {
            _songs = songs;
        }

        public bool HasNext()
        {
            return _currentIndex < _songs.Count;
        }

        public string Next()
        {
            return _songs[_currentIndex++];
        }
    }

}
using System;
using System.Collections.Generic;
using System.Text;

namespace KillImagineDragons.Songs
{
    public class Song
    {
        public string Artist { get; }
        public string SongName { get; }

        public Song(string songName, string artist)
        {
            Artist = artist;
            SongName = songName;
        }
    }
}

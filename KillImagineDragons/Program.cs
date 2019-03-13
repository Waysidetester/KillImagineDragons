using KillImagineDragons.Songs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>
            {
                new Song("Dream Theater", "Untethered Angel"),
                new Song("Head Above Water", "Avril Lavigne"),
                new Song("F*** Wade", "Michael Trapson"),
                new Song("Firelight", "Within Temptation"),
                new Song("Giant", "Calvin Harris"),
                new Song("Keanu Reeves", "Logic"),
                new Song("Leave Me Lonely", "Hilltop Hoods"),
                new Song("Meet Again", "Maxo Kream"),
                new Song("I Was Me", "Imagine Dragons"),
                new Song("Not Today", "Imagine Dragons"),
                new Song("Polaroid", "Imagine Dragons"),
                new Song("Radioactive", "Imagine Dragons")
            };

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"\"{song.SongName}\" is performed by {song.Artist}\n");
            }

            Console.ReadKey();
        }
    }
}

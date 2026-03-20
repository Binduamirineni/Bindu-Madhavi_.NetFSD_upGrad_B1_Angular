using System;
using System.Collections.Generic;

namespace MusicPlaylistSystem
{
    // Song Class
    public class Song
    {
        // Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        // Constructor
        public Song(int id, string title, string artist)
        {
            Id = id;
            Title = title;
            Artist = artist;
        }
    }

    class Program
    {
        static void Main()
        {
            LinkedList<Song> playlist = new LinkedList<Song>();

            // Add at beginning
            var song1 = new Song(1, "Song A", "Artist 1");
            playlist.AddFirst(song1);

            // Add at end
            var song2 = new Song(2, "Song B", "Artist 2");
            playlist.AddLast(song2);

            // Add in middle (after Song A)
            var song3 = new Song(3, "Song C", "Artist 3");
            var node = playlist.Find(song1);
            if (node != null)
                playlist.AddAfter(node, song3);

            // Add another at end
            var song4 = new Song(4, "Song D", "Artist 4");
            playlist.AddLast(song4);

            Console.WriteLine("---- Playlist (Forward) ----");
            foreach (var song in playlist)
            {
                Console.WriteLine($"{song.Id} - {song.Title} - {song.Artist}");
            }

            // Remove a specific song
            Console.WriteLine("\n---- Removing Song B ----");
            var removeSong = playlist.Find(song2);
            if (removeSong != null)
                playlist.Remove(removeSong);

            // Traverse backward
            Console.WriteLine("\n---- Playlist (Backward) ----");
            var current = playlist.Last;
            while (current != null)
            {
                Console.WriteLine($"{current.Value.Id} - {current.Value.Title} - {current.Value.Artist}");
                current = current.Previous;
            }

            // Find song by title
            Console.WriteLine("\n---- Find Song (Title = Song C) ----");
            foreach (var song in playlist)
            {
                if (song.Title == "Song C")
                {
                    Console.WriteLine($"Found: {song.Title} by {song.Artist}");
                }
            }

            // BONUS: Play Next Feature
            Console.WriteLine("\n---- Play Next Feature ----");
            var currentSong = playlist.First;

            while (currentSong != null)
            {
                Console.WriteLine("Now Playing: " + currentSong.Value.Title);
                currentSong = currentSong.Next;
            }
        }
    }
}
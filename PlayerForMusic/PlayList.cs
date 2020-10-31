namespace PlayerForMusic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Play list.
    /// </summary>
    public class PlayList
    {
        private static int counter = 20;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayList"/> class.
        /// </summary>
        public PlayList()
        {
            IdentifierPlayList = counter;
            counter++;
        }

        /// <summary>
        /// Gets unique PlayList Identifier.
        /// </summary>
        public int IdentifierPlayList { get; }

        /// <summary>
        /// Gets or sets Title play list.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Duration play list.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets songs play list.
        /// </summary>
        public List<Song> Songs { get; set; } = new List<Song>();

        /// <summary>
        /// Add Song In PlayList.
        /// </summary>
        /// <param name="song">The song to be added to the playlist.</param>
        public void AddSongInPlayList(Song song)
        {
            Songs.Add(song);
            Duration += song.DurationData;
        }

        /// <summary>
        /// Add Song In PlayList.
        /// </summary>
        /// <param name="song">The song to be removed to the playlist.</param>
        public void RemoveSongInPlayList(Song song)
        {
            Songs.Remove(song);
            Duration -= song.DurationData;
        }

        /// <summary>
        /// Search for a song on the playlist.
        /// </summary>
        /// <param name="nameSong">The name of the song to be found.</param>
        /// <returns>Song or Null, if there is no such song.</returns>
        public Song SearchSong(string nameSong)
        {
            foreach (var song in Songs)
            {
                if (song.Title.IndexOf(nameSong) != -1)
                {
                   return song;
                }
            }

            return null;
        }

        /// <summary>
        /// Play Songs in playlist.
        /// </summary>
        public void PlaySongs()
        {
            Console.WriteLine("select 1 for sequential playing or 2 for random playing.");

            switch (byte.Parse(Console.ReadLine()))
            {
                case 1:
                    foreach (var song in Songs)
                    {
                        Console.WriteLine(song.Title);
                    }

                    break;
                case 2:
                    Random rand = new Random();
                    int couter = Songs.Count;
                    List<int> indexesSongsPlayed = new List<int>();
                    while (couter != 0)
                    {
                        int temp = rand.Next(0, Songs.Count);
                        if (!indexesSongsPlayed.Contains(temp))
                        {
                            Console.WriteLine(Songs[temp].Title);
                            indexesSongsPlayed.Add(temp);
                        }
                    }

                    break;
                default:
                    Console.WriteLine("You made the wrong choice");
                    break;
            }
        }
    }
}

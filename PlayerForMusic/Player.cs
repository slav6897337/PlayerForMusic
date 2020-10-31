namespace PlayerForMusic
{
    using System;

    /// <summary>
    /// Player class for playing the playlist.
    /// </summary>
    public static class Player
    {
        /// <summary>
        /// Play Music.
        /// </summary>
        public static void PlayMusic()
        {
            Song blancoBrown = new Song("The Git Up", 3, "d:/Music");
            Song sturgillSimpson = new Song("Make Art Not Friends", 3, "d:/Music");
            Song ladyAntebellum = new Song("What If I Never Get Over You", 3, "d:/Music");
            Song koffee = new Song("Rapture", 3, "d:/Music");
            Song lewisCapaldi = new Song("Someone You Loved", 3, "d:/Music");
            Song adamLambert = new Song("Superpower", 3, "d:/Music");

            PlayList playList = new PlayList();
            playList.AddSongInPlayList(blancoBrown);
            playList.AddSongInPlayList(sturgillSimpson);
            playList.AddSongInPlayList(ladyAntebellum);
            playList.AddSongInPlayList(koffee);
            playList.AddSongInPlayList(lewisCapaldi);
            playList.AddSongInPlayList(adamLambert);
            Console.WriteLine(playList.SearchSong("Make").Title);
            Console.WriteLine("________________");
            playList.PlaySongs();
        }
    }
}

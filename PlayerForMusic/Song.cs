namespace PlayerForMusic
{
    using System;

    /// <summary>
    /// Song.
    /// </summary>
    public class Song
    {
        private static int counter = 1000;

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class.
        /// </summary>
        public Song()
        {
            Identifier = counter;
            counter++;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class.
        /// </summary>
        /// <param name="title">Song title.</param>
        /// <param name="durationData">Song duration data.</param>
        /// <param name="pathFile">Path to the song file.</param>
        public Song(string title, int durationData, string pathFile)
            : this()
        {
            Title = title;
            DurationData = durationData;
            PathFile = pathFile;
        }

        /// <summary>
        /// Gets unique song Identifier.
        /// </summary>
        public int Identifier { get; }

        /// <summary>
        /// Gets or sets song title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets song duration data.
        /// </summary>
        public int DurationData { get; set; }

        /// <summary>
        /// Gets or sets path to the song file.
        /// </summary>
        public string PathFile { get; set; }
    }
}

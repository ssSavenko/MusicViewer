using System;

namespace MusicViewer
{
    internal class Track
    {
        private DateTime dateRealese;
        private string genre;
        private readonly int id;
        private string length;
        private string name;

        public Track(string name, DateTime dateRealese, string genre, string length, int id)
        {
            this.id = id;
            this.name = name;
            this.dateRealese = dateRealese;
            this.genre = genre;
            this.length = length;
        }

        public DateTime DateRealese
        {
            get { return dateRealese; }
        }

        public string Genre
        {
            get { return genre; }
        }

        public string Length
        {
            get { return length; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
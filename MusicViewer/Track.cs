using System;

namespace MusicViewer
{
    internal class Track
    {
        private DateTime dateTime;
        private string genre;
        private readonly int id;
        private string length;
        private string name;

        public Track(string name, DateTime dateTime, string genre, string length, int id)
        {
            this.id = id;
            this.name = name;
            this.dateTime = dateTime;
            this.genre = genre;
            this.length = length;
        }

        public DateTime Date
        {
            get { return dateTime; }
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
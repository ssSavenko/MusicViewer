using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicViewer
{
    internal class Track
    {
        readonly int id;
        string trackName;
        string genre;
        string length;
        DateTime dateTime;

        public Track(string trackName, DateTime dateTime, string genre, string length, int id)
        {
            this.id = id;
            this.trackName = trackName;
            this.dateTime = dateTime;
            this.genre = genre;
            this.length = length;
        }

        public string Genre
        {
            get { return genre; }
        }

        public string Length
        {
            get { return length; }
        }

        public DateTime TrackDateTime
        {
            get { return dateTime; }
        }

        public string TrackName
        {
            get { return trackName; }
        }
    }
}
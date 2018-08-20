using System;
using System.Collections.Generic;

namespace MusicViewer
{
    internal class Album
    {
        private readonly int id;
        private List<Track> musicList;
        private string name;

        public Album(string name, int id)
        {
            musicList = new List<Track>();
            this.name = name;
            this.id = id;
        }

        public Track this[int i]
        {
            get
            {
                Track returnMusic = null;
                if (i < musicList.Count)
                {
                    returnMusic = musicList[i];
                }
                return returnMusic;
            }
        }

        public int CountOfTracks
        {
            get { return musicList.Count; }
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public void Add(string albumName, DateTime calendarDay, string genre, string length, int id)
        {
            musicList.Add(new Track(albumName, calendarDay, genre, length, id));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
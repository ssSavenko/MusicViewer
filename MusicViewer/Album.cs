using System;
using System.Collections.Generic;

namespace MusicViewer
{
    internal class Album
    {
        private readonly int id;
        private List<Track> music;
        private string name;

        public Album(string name, int id)
        {
            music = new List<Track>();
            this.name = name;
            this.id = id;
        }

        public Track this[int i]
        {
            get
            {
                Track selectedMusic = null;
                if (i < music.Count)
                {
                    selectedMusic = music[i];
                }
                return selectedMusic;
            }
        }

        public int CountOfTracks
        {
            get { return music.Count; }
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public void Add(string name, DateTime calendarDay, string genre, string length, int id)
        {
            music.Add(new Track(name, calendarDay, genre, length, id));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
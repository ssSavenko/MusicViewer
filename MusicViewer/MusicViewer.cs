using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MusicViewer
{
    public partial class MusicViewer : Form
    {
        private Album currentAlbum;
        private List<Album> albums;
        private DateTime pastMaximumPick;
        private DateTime pastMinimumPick; 
        private string xmlFilePath;

        public MusicViewer()
        {
            albums = new List<Album>();
            InitializeComponent();

            pastMinimumPick = MinimumDatePicker.Value;
            pastMaximumPick = MaximumDatePicker.Value;
        }

        private void AlbumsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < albums.Count; i++)
            {
                if (albumsComboBox.SelectedItem.ToString() == albums[i].ToString())
                {
                    currentAlbum = albums[i];
                    break;
                }
            }
            AddTracksByDate();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = openFileDialog.FileName;
                timer.Start();
                if (xmlFilePath != null || xmlFilePath != "")
                {
                    LoadXmlFile();
                }
            }
        }

        private void MaximumDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (MaximumDatePicker.Value < MinimumDatePicker.Value || MaximumDatePicker.Value > DateTime.Today)
            {
                MaximumDatePicker.Value = pastMaximumPick;
            }
            else
            {
                pastMaximumPick = MaximumDatePicker.Value;
            }
            AddTracksByDate();
        }

        private void MinimumDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (MaximumDatePicker.Value < MinimumDatePicker.Value || MinimumDatePicker.Value > DateTime.Today)
            {
                MinimumDatePicker.Value = pastMinimumPick;
            }
            else
            {
                pastMinimumPick = MinimumDatePicker.Value;
                AddTracksByDate();
            }
            AddTracksByDate();
        }

        private void TracksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < currentAlbum.CountOfTracks; i++)
            {
                if (tracksListBox.SelectedItem.ToString() == currentAlbum[i].Name)
                {
                    albumDataLabel.Text = currentAlbum.Name;
                    realeseDataLabel.Text = currentAlbum[i].DateRealese.Day.ToString() + " ";
                    realeseDataLabel.Text += currentAlbum[i].DateRealese.Month.ToString() + ", ";
                    realeseDataLabel.Text += currentAlbum[i].DateRealese.Year.ToString();
                    lengthDataLabel.Text = currentAlbum[i].Length;
                    genreDataLabel.Text = currentAlbum[i].Genre;
                    break;
                }
            }
        }

        private void AddTracksByDate()
        {
            tracksListBox.Items.Clear();
            for (int i = 0; i < currentAlbum.CountOfTracks; i++)
            {
                if (currentAlbum[i].DateRealese >= MinimumDatePicker.Value && currentAlbum[i].DateRealese <= MaximumDatePicker.Value)
                {
                    tracksListBox.Items.Add(currentAlbum[i].Name);
                }
            }
        }

        private void LoadXmlFile()
        {
            albums.Clear();
            albumsComboBox.Items.Clear();
            var document = new XmlDocument();
            document.Load(xmlFilePath);
            
            XmlNode albumsNode = document.DocumentElement.FirstChild;
            XmlNode artistsNode = albumsNode.NextSibling;
            XmlNode genresNode = artistsNode.NextSibling;
            XmlNode tracksNode = genresNode.NextSibling;
            
            Dictionary<int, string> genres = new Dictionary<int, string>();

            string albumName;
            int albumId;
            
            foreach (XmlNode album in albumsNode)
            {
                albumName = album.Attributes["name"].Value;
                albumId = int.Parse(album.Attributes["id"].Value);
                albums.Add(new Album(albumName, albumId));
            }

            string genreName;
            int genreId;

            foreach (XmlNode genre in genresNode)
            {
                genreName = genre.Attributes["name"].Value;
                genreId = int.Parse(genre.Attributes["id"].Value);
                genres.Add(genreId, genreName);
            }

            int trackId;
            int trackAlnumId;
            DateTime trackDate;
            string trackDateInString;
            string trackName;
            string trackGenre;
            string trackLength;
            List<string> trackGenres = new List<string>();

            foreach (XmlNode track in tracksNode)
            {
                trackName = track.Attributes["name"].Value;
                trackId = int.Parse(track.Attributes["id"].Value);
                trackAlnumId = int.Parse(track.Attributes["album-id"].Value);
                trackLength = track.Attributes["length"].Value;

                trackDateInString = track.Attributes["released"].Value;
                List<string> dayMonthYear = new List<string>();
                StringBuilder currentDatePart = new StringBuilder();
                for (int characterNumber = 0; characterNumber < trackDateInString.Length; characterNumber++)
                {
                    if (trackDateInString[characterNumber] != '.')
                    {
                        currentDatePart.Append(trackDateInString[characterNumber]);
                    }
                    else
                    {
                        dayMonthYear.Add(currentDatePart.ToString());
                        currentDatePart.Clear();
                    }
                }

                dayMonthYear.Add(currentDatePart.ToString());
                trackDate = new DateTime(int.Parse(dayMonthYear[2]), int.Parse(dayMonthYear[1]), int.Parse(dayMonthYear[0]));

                trackGenre = "";
                trackGenres.Clear();
                var tracksGenreNode = track.FirstChild;

                foreach (XmlNode trackGenreNode in tracksGenreNode)
                {
                    int trackGenreId = int.Parse(trackGenreNode.Attributes["genre-id"].Value);
                    trackGenres.Add(genres[trackGenreId]);
                }

                trackGenres.Sort();

                foreach (string currrentTrackGenre in trackGenres)
                {
                    if (currrentTrackGenre != trackGenres[0])
                    {
                        trackGenre += ", ";
                    }
                    trackGenre += currrentTrackGenre;
                }

                for(int i =0; i < albums.Count; i++)
                {
                    if (albums[i].Id == trackAlnumId)
                    {
                        albums[i].Add(trackName, trackDate,trackGenre, trackLength, trackId);
                    }
                }
            }

            foreach (Album album in albums)
            {
                albumsComboBox.Items.Add(album);
            }
        }
    }
}
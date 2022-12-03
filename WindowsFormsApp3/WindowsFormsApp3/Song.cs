using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    public class Song
    {
        public string filePath { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public TimeSpan duration { get; set; }
        public Image image { get; set; }
        public Song()
        {
        }

        public Song(string _filePath, string _title, string _year, TimeSpan _duration)
        {
            this.filePath = _filePath; ;
            this.title = _title;
            this.year = _year;
            this.duration = _duration;
        }
        //public Song Add(string _filePath, string _title, string _year, TimeSpan _duration)
        public Song Add(string _filePath, string _title, string _year, TimeSpan _duration)
        {
            Song a = new Song();

            //a.duration = _duration;
            return a;
        }

    }
}

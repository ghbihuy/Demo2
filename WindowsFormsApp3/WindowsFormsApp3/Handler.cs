using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlaylist.Properties;
using MusicPlaylist;


namespace MusicPlaylist
{
    class Handler
    {

        public LinkedList<Song> muslicList = new LinkedList<Song>();

        //Check Variables
        public LinkedListNode<Song> currentNodeSong;
        public Song currentSong;
        public double currentPosition; //thời gian phát hiện tại
        public int totalSong; //tổng số bài nhạc
        private bool isPlaying;

        WMPLib.WindowsMediaPlayer bai1 = new WMPLib.WindowsMediaPlayer();
        public LinkedList<Song> ListSong(string __path)
        {
            LinkedList<Song> A = new LinkedList<Song>();
            if (A.Count == 0)
            {
                Console.WriteLine("Chưa có bài hát nào trong list");
            }
            return A;
        }
       
    }
}

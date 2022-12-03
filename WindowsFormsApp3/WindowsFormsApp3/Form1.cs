using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//using MusicPlaylist.Handler;

namespace MusicPlaylist
{
#pragma warning disable 8604, 8618, 8600, 8602, 649
    public partial class Form1 : Form
    {
        #region Properties
        public bool isPlaying;
        public string currentSong;
        public string temp;
        public bool isMute;
        public bool isNext;
        public bool isLoop;
        public bool isRandom;
        #endregion

        WMPLib.WindowsMediaPlayer bai1 = new WMPLib.WindowsMediaPlayer();
        LinkedList<string> playList = new LinkedList<string>();
        public Form1()
        {
            //SoundPlayer bai2 = new SoundPlayer("Anthan.wav");
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        //Chuyển bài

        //Quay lại

        //Chuyển xuống cuối

        // Chuyển về đầu


        private void Play_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                //bai1.URL = "An than.mp3";
                bai1.controls.play();
                isPlaying = true;
            }
            else
            {
                bai1.controls.pause();
                isPlaying = false;
            }
        }

        
        private void Open_Click(object sender, EventArgs e)
        {
            playList.AddLast("MANBO - REEVES (ft. HIEUTHUHAI, HURRYKNG) (Prod. by Rev).mp3");
            playList.AddFirst("An Thần (ft. Thắng) - Low G - Rap Nhà Làm .mp3");
            playList.AddLast("Justin Bieber - Mistletoe (Official Music Video).mp3");
            playList.AddLast("TOULIVER X LÊ HIẾU X SOOBIN HOÀNG SƠN - NGÀY MAI EM ĐI 2017 - OFFICIAL LYRIC VIDEO.mp3");
            playList.AddLast("YÊU 5 - Rhymastic.mp3");
            playList.AddLast("Justin Bieber - Peaches ft. Daniel Caesar, Giveon.mp3");
            playList.AddLast("Bruno Mars vs. David Guetta - Versace on The Floor (Official Audio).mp3");

            bai1.URL = playList.First.Value;
            currentSong = playList.First.Value;
            bai1.controls.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (playList.Find(currentSong).Next != null)
            {
            bai1.URL = playList.Find(currentSong).Next.Value;
            currentSong = playList.Find(currentSong).Next.Value;
            bai1.controls.play();
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (playList.Find(currentSong).Previous != null)
            {
            bai1.URL = playList.Find(currentSong).Previous.Value;
            currentSong = playList.Find(currentSong).Previous.Value;
            bai1.controls.play();            
            }
        }

        private void First_Click(object sender, EventArgs e)
        {
            bai1.URL = playList.First.Value;
            currentSong = playList.First.Value;
            bai1.controls.play();
        }

        private void Last_Click(object sender, EventArgs e)
        {
            bai1.URL = playList.Last.Value;
            currentSong = playList.Last.Value;
            bai1.controls.play();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

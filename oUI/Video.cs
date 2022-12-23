using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace obedtwLAPI.oUI
{
    /// <summary>
    /// Video Control
    /// </summary>
    public partial class Video : UserControl
    {
        public string URL;
      
        /// <summary>
        /// Video Control
        /// </summary>
        /// <param name="VideoTitle"></param>
        /// <param name="URL"></param>
        /// <param name="IMGURL"></param>
        public Video()
        {
           
           
            InitializeComponent();

            
            try { var youtube = new YoutubeClient(); Label1.Text = youtube.Videos.GetAsync(URL).Result.Title; PictureBox1.LoadAsync(youtube.Videos.GetAsync(URL).Result.Thumbnails.TryGetWithHighestResolution().Url); } catch  { if (System.IO.File.Exists(URL)) { Label1.Text = Path.GetFileNameWithoutExtension(URL);PictureBox1.Image=oFile.GetThumbnail(URL); PictureBox1.LoadAsync(); } else { Label1.Text = Path.GetFileNameWithoutExtension(URL); } }


            }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Video_Load(object sender, EventArgs e)
        {
         
            
        }

        private void Video_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.DarkGray;
            }
            this.BackColor = Color.DarkGray;
        }

        private void Video_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.Black;
            }
            this.BackColor = Color.Black;
        }
    }
}

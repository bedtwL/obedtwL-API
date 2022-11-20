using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode.Videos;

namespace obedtwLAPI.oUI
{
    /// <summary>
    /// Video Control
    /// </summary>
    public partial class Video : UserControl
    {
        string _URL;
        /// <summary>
        /// Video Control
        /// </summary>
        /// <param name="VideoTitle"></param>
        /// <param name="URL"></param>
        /// <param name="IMGURL"></param>
        public Video(string VideoTitle,string URL,string IMGURL)
        {
            _URL = URL;
           
            InitializeComponent();
            Label1.Text = VideoTitle;
            try { YoutubeExplode.Videos.VideoId.Parse(_URL); } catch  { if (System.IO.File.Exists(_URL)) { } else { } }


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

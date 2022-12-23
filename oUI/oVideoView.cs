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

namespace obedtwLAPI.oUI
{
    public partial class oVideoView : UserControl
    {
        /// <summary>
        /// Vlc Lib Path
        /// </summary>
        public string VlcLibPath = "";
        /// <summary>
        /// Get FriendllyTime
        /// </summary>
        public string FriendllyTime="00:00";
        /// <summary>
        /// Get Friendlly Video Length For Core
        /// </summary>
        public static string FriendllyLengthTime = "00:00";
        /// <summary>
        /// A VideoView Control, Reqired https://www.nuget.org/packages/Vlc.DotNet.Forms
        /// </summary>
        public oVideoView()
        {
            
            this.oVideoViewCore.VlcLibDirectory= new System.IO.DirectoryInfo(VlcLibPath);
            ((System.ComponentModel.ISupportInitialize)(this.oVideoViewCore)).EndInit();
            InitializeComponent();
        }

        private void oVideoView_Load(object sender, EventArgs e)
        {

        }

        private void oVideoViewCore_TimeChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerTimeChangedEventArgs e)
        {
            FriendllyTime= oConverter.ToFriendllyTime(oVideoViewCore.Time);
            
        }
        private void oVideoViewCore_MediaChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerMediaChangedEventArgs e)
        {
            FriendllyLengthTime = oConverter.ToFriendllyTime(oVideoViewCore.Length);
        }

        private void oVideoViewCore_Click(object sender, EventArgs e)
        {

        }
        public void LoadVideo(string URL)
        {
            try { var Youtube = new oWeb.Youtube();oVideoViewCore.Play(Youtube.GetVideoDownloadUrl(URL)); } catch { oVideoViewCore.Play(); }
            
        }
    }
}

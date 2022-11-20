using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;
using YoutubeExplode.Videos;
namespace obedtwLAPI.oWeb
{
    /// <summary>
    /// YoutubeBrowser Class Reqired https://www.nuget.org/packages/Microsoft.Web.WebView2 and https://www.nuget.org/packages/YoutubeExplode
    /// </summary>
    public partial class YoutubeBrowser : Form
    {
        /// <summary>
        /// Get User Selected Video URL
        /// if User not select it will return null.
        /// </summary>
        public string UserSelectVideoURL="";
        /// <summary>
        /// A YoutubeBrowser Class Reqired https://www.nuget.org/packages/Microsoft.Web.WebView2 and https://www.nuget.org/packages/YoutubeExplode
        /// </summary>
        public YoutubeBrowser()
        {
            InitializeComponent();
            
        }

        private void YoutubeBrowser_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://youtube.com");
        }

        private void webView21_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            e.Cancel = true;
            try { VideoId.Parse(e.Uri); UserSelectVideoURL = e.Uri; this.Close(); } catch { e.Cancel = false; } 
        }
    }
}

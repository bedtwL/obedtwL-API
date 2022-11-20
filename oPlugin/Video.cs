using obedtwLAPI.oWeb;
using obedtwLAPI.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
namespace obedtwLAPI.oPlugin
{
    /// <summary>
    /// A Video class reqired https://www.nuget.org/packages/YoutubeExplode plugin.
    /// </summary>
    public class Video:Plugin
    {
        Youtube youtube;
        List<string> videosinqueue;
        int queueNow=0;
        /// <summary>
        /// A Video class reqired https://www.nuget.org/packages/YoutubeExplode plugin.
        /// </summary>
        public Video():base("Video-Addon")
        {
            youtube= new Youtube();
            videosinqueue= new List<string>();
        }
        /// <summary>
        /// Get Url to Play.
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public string ParseToUrl(string Url)
        {
            try {return youtube.GetVideoDownloadUrl(Url); } catch { return Url; }
           
        }
        /// <summary>
        /// Add Video into Queue
        /// </summary>
        /// <param name="Url"></param>
        public void AddIntoQueue(string Url)
        {
            videosinqueue.Add(Url);
        }
        /// <summary>
        /// Remove Video From queue
        /// </summary>
        /// <param name="Url"></param>
        public void RemoveFromQueue(string Url) 
        {
            videosinqueue.Remove(Url);
        }
        /// <summary>
        /// Get Next Video in queue URL
        /// </summary>
        /// <returns></returns>
        public string GetNextVideoFromQueue()
        {
            string value= videosinqueue[queueNow];
            queueNow++;
            if (queueNow > videosinqueue.Count)
            { queueNow =0; }
            return value;
        }
        /// <summary>
        /// Get all video count in queue
        /// </summary>
        /// <returns></returns>
        public int GetVideoNumberInQueueNow()
        {
            return videosinqueue.Count;
        }
        /// <summary>
        /// Get Number of next video
        /// </summary>
        /// <returns></returns>
        public int GetVideoPlayingNext()
        {
            return queueNow+1;
        }
        /// <summary>
        /// Clear Queue Video.
        /// </summary>
        public void ClearQueue()
        {
            videosinqueue.Clear();
            queueNow = 0;
        }

    }
}

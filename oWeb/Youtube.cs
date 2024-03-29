﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace obedtwLAPI.oWeb
{
    /// <summary>
    /// A Youtube Class Reqired https://www.nuget.org/packages/YoutubeExplode
    /// Also Reqired Internet
    /// </summary>
    public class Youtube
    {
        /// <summary>
        /// A Youtube Class Reqired https://www.nuget.org/packages/YoutubeExplode
        /// Also Reqired Internet
        /// </summary>
        public Youtube()
        {
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "YoutubeExplode.dll"))
            { }
            else { var random = new Random(); oUILauncher.ErrorReporter("YoutubeExplode.dll is Not Exist!","Error 1 (File NotExist)",random.Next(0,32767)); }
        }
        /// <summary>
        /// Get Video URL With 720p Video
        /// </summary>
        /// <param name="YoutubeURL"></param>
        public string GetVideoDownloadUrl(string YoutubeURL)
        {
            var youtube = new YoutubeClient();
            return youtube.Videos.Streams.GetManifestAsync(YoutubeURL).Result.GetMuxedStreams().TryGetWithHighestVideoQuality().Url;

        }
        /// <summary>
        /// Download Youtube Video async
        /// </summary>
        /// <param name="YoutubeURL"></param>
        /// <param name="FileName"></param>
        public async void DownloadVideoAsync(string YoutubeURL,string FileName)
        {
            await Task.Delay(1);
            oWeb.Download(GetVideoDownloadUrl(YoutubeURL),FileName);

        }
        /// <summary>
        /// Download Youtube Video
        /// </summary>
        /// <param name="YoutubeURL"></param>
        /// <param name="FileName"></param>
        public void DownloadVideo(string YoutubeURL, string FileName)
        {
            
            oWeb.Download(GetVideoDownloadUrl(YoutubeURL), FileName);

        }
        /// <summary>
        /// Get Caption Download Url
        /// </summary>
        /// <param name="YoutubeURL"></param>
        /// <param name="CaptionCode"></param>
        /// <returns></returns>
        public string GetCaptionURL(string YoutubeURL,string CaptionCode)
        {
            var youtube = new YoutubeClient();
            YoutubeExplode.Videos.ClosedCaptions.ClosedCaptionManifest trackManifest = youtube.Videos.ClosedCaptions.GetManifestAsync(YoutubeURL).Result;
            var trackInfo = trackManifest.GetByLanguage(CaptionCode);
            return trackInfo.Url;
        }
        /// <summary>
        /// Download Caption from Youtube Video async
        /// </summary>
        /// <param name="YoutubeURL"></param>
        /// <param name="FileName"></param>
        public async void DownloadCaptionAsync(string YoutubeURL,string CaptionCode, string FileName)
        {
            await Task.Delay(1);
            oWeb.Download(GetCaptionURL(YoutubeURL,CaptionCode), FileName);

        }
        /// <summary>
        /// Download Caption from Youtube Video
        /// </summary>
        /// <param name="YoutubeURL"></param>
        /// <param name="FileName"></param>
        public void DownloadCaption(string YoutubeURL,string CaptionCode, string FileName)
        {

            oWeb.Download(GetCaptionURL(YoutubeURL, CaptionCode), FileName);

        }
        /// <summary>
        /// Get Video Thumbnail
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public string GetThumbnailURL(string URL)
        {
            var Youtube = new YoutubeClient();
            return Youtube.Videos.GetAsync(URL).Result.Thumbnails.TryGetWithHighestResolution().Url;
        }
        /// <summary>
        /// Get User Image by URL
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public string GetUserImage(string Url)
        {
            var youtube = new YoutubeClient();
            try { return youtube.Channels.GetAsync(youtube.Videos.GetAsync(Url).Result.Author.ChannelUrl).Result.Thumbnails.TryGetWithHighestResolution().Url; }
            catch { return youtube.Channels.GetAsync(Url).Result.Thumbnails.TryGetWithHighestResolution().Url; }
            
        }
        /// <summary>
        /// Get Channel Username by URL
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public string GetUserName(string Url)
        {
            var youtube = new YoutubeClient();
            return youtube.Videos.GetAsync(Url).Result.Author.ChannelTitle;
        }
        /// <summary>
        /// Get Video MetaData
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public YoutubeExplode.Videos.Video GetVideoMetaData(string URL)
        {
            var Youtube = new YoutubeClient();
            return Youtube.Videos.GetAsync(URL).Result;
        }
    }
}

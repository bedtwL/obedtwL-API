using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI.oWeb
{
    /// <summary>
    /// Web Feature
    /// </summary>
    public class oWeb
    {
        /// <summary>
        /// Download a File from URL.
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="FilePath"></param>
        public static void Download(string Url,string FilePath)
        {
            var WebClient=new WebClient();
            WebClient.DownloadFile(Url, FilePath);
        }
    }

}

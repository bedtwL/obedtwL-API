using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI.Plugins
{
    /// <summary>
    /// obedtwLAPI Plugin class Plugin is still Working on making!
    /// </summary>
    public class oPlugin:Plugin
    {
        /// <summary>
        /// obedtwLAPI Plugin class
        /// </summary>
        public oPlugin() : base("oPluginLoader")
        {
            System.IO.Directory.CreateDirectory(Info.GlobalPath + "\\plugins");
            try { System.IO.File.WriteAllText(Info.GlobalPath+"\\plugins\\oPluginLoader.oplugin",$"oPluginLoader- Build For obedtwLAPI"); } catch { }
            try { System.IO.File.WriteAllText(Info.GlobalPath + "\\plugins\\obedtwLAPI.oplugin", $"oAPILoader- Build For obedtwLAPI"); } catch { }
            try { System.IO.File.WriteAllText(Info.GlobalPath + "\\plugins\\oUI.oplugin", $"oUILoader- Build For obedtwLAPI"); } catch { }
        }

        /// <summary>
        /// List plugin in Globalpath/plugins
        /// </summary>
        /// <returns></returns>
        public static string[] ListPlugins()
        {
            
            DirectoryInfo d = new DirectoryInfo(Info.GlobalPath+"\\plugins"); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.oplugin"); //Getting Text files
            List<string> plugins = new List<string>();
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "YoutubeExplode.dll"))
            {
                plugins.Add("YoutubeExplode");

            }
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Microsoft.Web.WebView2.Core.dll"))
            {
                plugins.Add("WebView2");

            }
            foreach (FileInfo file in Files)
            {
                plugins.Add(file.Name);
            }

            return plugins.ToArray();
        }
        public static string ListPlugin()
        {
           
            DirectoryInfo d = new DirectoryInfo(Info.GlobalPath + "\\plugins"); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.oplugin"); //Getting Text files
            string str="";
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "YoutubeExplode.dll"))
            {
                str = str + "YoutubeExplode , ";

            }
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Microsoft.Web.WebView2.Core.dll"))
            {
                str = str + "WebView2 , ";

            }
            foreach (FileInfo file in Files)
            {
                str = str + file.Name.Replace(".oplugin","") + " , ";
            }
            
            return str;
        }
        public static bool GetPluginExist(Plugin plugin)
        {
            return System.IO.File.Exists(plugin.PluginName);
            
            
        }
    }
    /// <summary>
    /// obedtwLAPI Plugin class Every plugin Class is based on this.
    /// </summary>
    public class Plugin
    {
        public string PluginName="";
        public Plugin(string Pluginname)
        {
            PluginName = Pluginname;
        }
    }
}

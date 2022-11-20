# obedtwL API
A API for C# Developer
| API Version |  Release/Prerelease Code  |
| ----------| ----------------------------------------|
| v0.0.0.1 ~ v0.0.0.1360| Console API Beta Release|
| v0.0.0.1361 ~ v0.0.0.9999| Beta Release|
| v0.0.1.0 ~ v0.0.9999.9999| PreRelease|
| v0.1.0.0 ~ v9997.9999.9999.9999 and v9999.0.0.0 ~ | Release|
| v9998.0.0.0 ~ v9998.9999.9999.9999| Special Release/PreRelease|

## Reqiredment

This is ONLY reqired if the class that you want to use is in below
You can download all dll from dll-pack.zip on Release
Waring: dll-pack.zip will not update to newest dll and i dont own the dll in dll-pack.zip

| Addon Make What class work |  Link   |
| ----------| ------------------------------------------------|
| obedtwLAPI.oPlugins.Video   | https://www.nuget.org/packages/YoutubeExplode|
| obedtwLAPI.oUI.oVideoView     | https://www.nuget.org/packages/Vlc.DotNet.Forms |
| obedtwLAPI.oWeb.Youtube   | https://www.nuget.org/packages/YoutubeExplode|
| obedtwLAPI.oWeb.YoutubeBrowser   | https://www.nuget.org/packages/Microsoft.Web.WebView2 and https://www.nuget.org/packages/YoutubeExplode|


 ## Beta Class
 | Beta Class Name | Issue |
 |---------|------------------|
 | obedtwLAPI.Speech.SpeechAPI | Some thing may working weird |

 ## API Usage:
   ### This Only Show to most Useful Usage
   #### obedtwLAPI.Info.ShowInfo()
   ```csharp
   obedtwLAPI.Info.ShowInfo(); //Shows up API & System infomation 
```
   #### obedtwLAPI.oWeb.Youtube.GetVideoDownloadUrl(string Url)
   Download Video From Youtube:
   
   ```csharp
   var Youtube = new obedtwLAPI.oWeb.Youtube();
   string URL = Youtube.GetVideoDownloadUrl(YoutubeVideoUrl); //Youtube Video URL is the url that you want to get download url
   obedtwLAPI.oWeb.Download(URL,"Video.mp4"); //Video.mp4 is the filename that you want to save
```
   #### obedtwLAPI.oConsole.WriteColorLine(string text,parms (string str,ConsoleColor color))
   Write Colored Line
      
   ```csharp
   obedtwLAPI.oConsole.WriteColorLine("This is Message have color",("{Message}",ConsoleColor.Red),("{color}",ConsoleColor.Blue));
   //Make "Message" text Color into Red and make "color" text into blue
```
   #### obedtwLAPI.oConsole.WriteColor(string text,parms (string str,ConsoleColor color))
   Write Colored Text
      
   ```csharp
   obedtwLAPI.oConsole.WriteColor("This is Message have color",("{Message}",ConsoleColor.Red),("{color}",ConsoleColor.Blue));
   //Make "Message" text Color into Red and make "color" text into blue
```

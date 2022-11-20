using Microsoft.Win32;
using obedtwLAPI.oBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obedtwLAPI
{
    /// <summary>
    /// Some stuff for API Info
    /// </summary>
    public static class Info
    {   /// <summary>
        /// Get API Global Data Path
        /// </summary>
        public static readonly string GlobalPath = "C:\\obedtwLAPI";
        /// <summary>
        /// Get or Set API Running Path Defealt is Same to Application Path+obedtwLAPI
        /// </summary>
        public static readonly string RunningPath =AppDomain.CurrentDomain.BaseDirectory+ "obedtwLAPI";
        /// <summary>
        /// Info Console Loader
        /// </summary>
        public static void Main(string[] args)
        {
            try {
                if (Environment.Is64BitProcess)
                {
                    if (System.IO.File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\x64BuildInfo"))
                    { }
                    else
                    {
                        System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\v" + Application.ProductVersion);
                        System.IO.File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\v" + Application.ProductVersion + "\\x64BuildInfo", "x64 Version obedtwLAPI " + Application.ProductVersion + " Update Time: " + DateTime.Now);
                        System.IO.File.Copy(Application.ExecutablePath, Path.GetDirectoryName(Application.ExecutablePath) + "\\v" + Application.ProductVersion + "\\obedtwLAPI x64.exe");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\x86BuildInfo"))
                    { }
                    else
                    {
                        System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\v" + Application.ProductVersion);
                        System.IO.File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\v" + Application.ProductVersion + "\\x86BuildInfo", "x86 Version obedtwLAPI " + Application.ProductVersion + " Update Time: " + DateTime.Now);
                        System.IO.File.Copy(Application.ExecutablePath, Path.GetDirectoryName(Application.ExecutablePath) + "\\v" + Application.ProductVersion + "\\obedtwLAPI x86.exe");
                    }
                }
            }
            catch { }
            ShowInfo();
            bedh.Bedh(args);
            do { Console.ReadLine(); } while (true);
            
        }
        /// <summary>
        /// Info Console
        /// </summary>
        public static void ShowInfo()
        {
            foreach (string infos in GetInfo())
            oConsole.WriteLineColor(infos,("{No}",ConsoleColor.Red), ("{Yes}", ConsoleColor.Green),("{Unknow}", ConsoleColor.Gray), ("{x64}", ConsoleColor.Green), ("{x86}", ConsoleColor.Red),("{oplugin}", ConsoleColor.Gray));
        }
        /// <summary>
        /// Get Info String
        /// </summary>
        public static string[] GetInfo()
        {
            string exefile = $"obedtwLAPI";
            if (Environment.Is64BitProcess)
            {
                exefile = exefile + " x64";
            }
            else if (Environment.Is64BitProcess == false)
            {
                exefile = exefile + " x86";
            }
            else { exefile = exefile + " arm64"; }
            var pluginLoader=new Plugins.oPlugin();
              return new String[] {$"{exefile}" +
                $"" ,
                $"" ,
                $"API Info:",
                $"   API global Setting Path: {GlobalPath}",
                $"   API Running Path: {RunningPath}",
                $"   API global Setting Path Exist: {oConverter.BoolToString(APIChecker.IsGlobalPathExist())}",
                $"   API Running Path Exist: {oConverter.BoolToString(APIChecker.IsRunningPathExist())}",
                $"   API Debug Mode: {oConverter.BoolToString(APIChecker.IsDebugMode())}",
                $"   API UI Mode: {oConverter.BoolToString(APIChecker.IsUIMode())}",
                $"   API Running Data Root: {Path.GetDirectoryName(RunningPath + "\\Dat")}" ,
                $"   API global Data Root: {Path.GetDirectoryName(GlobalPath + "\\Dat")}" ,
                $"   API Is Running on {Environment.MachineName}",
                $"   API Loaded Plugin: {Plugins.oPlugin.ListPlugin()}",
                $"" ,
                $"System Info:",
                $"   Machine Name: {Environment.MachineName}" ,
                $"   OS: {Environment.OSVersion}" ,
                  $"   OS-Name: {OSName()}" ,
                $"   Is64BitProcess: {oConverter.BoolToString(Environment.Is64BitProcess)}" ,
                $"   Is64BitOS: {oConverter.BoolToString(Environment.Is64BitOperatingSystem)}",
                $"   Machine Time (This ONLY Update when Info Showup): {DateTime.Now}",
                $"   Display language: {APIChecker.GetSystemDisplaylanguage()}",
                $"   OS Path: {Environment.GetFolderPath(Environment.SpecialFolder.Windows)}",
                $"   OS Root: {Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.Windows))}" };
        }
        /// <summary>
        /// Bind Console Into info  ONLY Console
        /// </summary>
        public async static void BindConsoleInfo()
        {
            do 
            {
                Console.Clear();
                ShowInfo();
                await Task.Delay(3000);
            } 
            while (true);
        }
        /// <summary>
        /// Bind Console Into info  ONLY Console with Custom Update Time
        /// </summary>
        public async static void BindConsoleInfo(int UpdateMillSeconed)
        {
            do
            {
                Console.Clear();
                ShowInfo();
                await Task.Delay(UpdateMillSeconed);
            }
            while (true);
        }
        /// <summary>
        /// Get Friendlly OS Name
        /// </summary>
        /// <returns></returns>
        public static string OSName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }
        /// <summary>
        /// Get UI Lang Code
        /// </summary>
        /// <returns></returns>
        public static string UILangCode()
        {
            CultureInfo ci = CultureInfo.CurrentUICulture;

            return ci.Name;
        }
        /// <summary>
        /// Try Register Your App
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="registeredApp"></param>
        /// <returns></returns>
        public static bool TryGetRegisteredApplication(string extension, out string registeredApp)
        {
            string extensionId = GetClassesRootKeyDefaultValue(extension);
            if (extensionId == null)
            {
                registeredApp = null;
                return false;
            }

            string openCommand = GetClassesRootKeyDefaultValue(
                    Path.Combine(new[] { extensionId, "shell", "open", "command" }));

            if (openCommand == null)
            {
                registeredApp = null;
                return false;
            }

            registeredApp = openCommand
                             .Replace("%1", string.Empty)
                             .Replace("\"", string.Empty)
                             .Trim();
            return true;
        }
        private static string GetClassesRootKeyDefaultValue(string keyPath)
        {
            using (var key = Registry.ClassesRoot.OpenSubKey(keyPath))
            {
                if (key == null)
                {
                    return null;
                }

                var defaultValue = key.GetValue(null);
                if (defaultValue == null)
                {
                    return null;
                }

                return defaultValue.ToString();
            }
        }
    }
}

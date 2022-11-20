using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI
{
    /// <summary>
    /// Check API
    /// </summary>
    public class APIChecker
    {   /// <summary>
        /// Fix API global Path
        /// </summary>
        public static void FixGlobalPath()
        {
            System.IO.Directory.CreateDirectory(Info.GlobalPath);

        }
        /// <summary>
        /// Is global Path Exist? if Exist then return value is true otherwise false
        /// </summary>
        public static bool IsGlobalPathExist()
        {
            return System.IO.Directory.Exists(Info.GlobalPath);

        }
        /// <summary>
        /// Fix API Running Path
        /// </summary>
        public static void FixRunningPath()
        {
            System.IO.Directory.CreateDirectory(Info.RunningPath);

        }
        /// <summary>
        /// Is Running Path Exist? if Exist then return value is true otherwise false
        /// </summary>
        public static bool IsRunningPathExist()
        {
            return System.IO.Directory.Exists(Info.RunningPath);

        }
        /// <summary>
        /// Is in Debug Mode? if is then return value is true otherwise false
        /// </summary>
        public static bool IsDebugMode()
        {
            return oData.GetDataBool("DebugMode");

        }
        /// <summary>
        /// Is in UI Mode? if is then return value is true otherwise false
        /// </summary>
        public static bool IsUIMode()
        {
            return oData.GetDataBool("UIMode");

        }
        /// <summary>
        /// Get System DIsplay Language Format: en-US
        /// </summary>
        public static string GetSystemDisplaylanguage()
        {
            
            
            return CultureInfo.CurrentUICulture.Name;

        }

    }
}

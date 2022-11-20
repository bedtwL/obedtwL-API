using AngleSharp.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI
{
    /// <summary>
    ///  Data Read/Save API.
    /// </summary>
    public class oData
    {
        /// <summary>
        /// Toggle Bool Data
        /// </summary>
        /// <param name="DataKey"></param>
        public static void ToggleDataBool(string DataKey)
        {
            if (oData.GetDataBool(DataKey))
            { oData.SaveData(DataKey, false); }
            else { oData.SaveData(DataKey, true); }
        }
        /// <summary>
        ///  Get Data.
        /// </summary>
        public static string GetData(string DataKey)
        {
            
            return null ?? System.IO.File.ReadAllText(Info.GlobalPath+"\\"+DataKey)?? System.IO.File.ReadAllText(Info.RunningPath + "\\" + DataKey);
        }
        /// <summary>
        ///  Get Data.
        /// </summary>
        public static bool GetDataBool(string DataKey)
        {
            try { return System.IO.File.Exists(Info.RunningPath + "\\" + DataKey); } catch { try { return System.IO.File.Exists(Info.GlobalPath + "\\" + DataKey); } catch { return false; }}
         
        }
        /// <summary>
        ///  Save Data.
        /// </summary>
        public static void SaveData(string DataKey, string Value)
        {
            string path = Info.RunningPath;
          
            System.IO.File.WriteAllText(path + "\\" + DataKey, Value);
        }
        /// <summary>
        ///  Save Data.
        /// </summary>
        public static void SaveData(string DataKey,string Value,DataLocation location)
        {
            string path = Info.RunningPath;
            if (location == DataLocation.Global)
            { path = Info.GlobalPath; }
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path + "\\" + DataKey));
            System.IO.File.WriteAllText(path + "\\" + DataKey, Value);
        }
        /// <summary>
        ///  Save Data.
        /// </summary>
        public static void SaveData(string DataKey, bool Value)
        {
            string path = Info.RunningPath;
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path + "\\"+DataKey));
            

            if (Value)
            { System.IO.File.WriteAllText(path + "\\" + DataKey, ""); }
            else { try { System.IO.File.Delete(path + "\\" + DataKey); } catch { } }
        }
        /// <summary>
        ///  Save Data.
        /// </summary>
        public static void SaveData(string DataKey, bool Value, DataLocation location)
        {
            string path = Info.RunningPath;
            if (location==DataLocation.Global)
            { path = Info.GlobalPath; }
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path + "\\" + DataKey));
            if (Value)
            { System.IO.File.WriteAllText(path + "\\" + DataKey, ""); }
            else { try { System.IO.File.Delete(path + "\\" + DataKey); } catch { }  }
            
        }
        /// <summary>
        ///  Data Location.
        /// </summary>
        public enum DataLocation
        {
            Global,App
        }

    }


}

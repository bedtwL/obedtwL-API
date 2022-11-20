using System.Collections.Generic;
using System.Linq;
using System.Net;
namespace obedtwLAPI
{
    public static class oFile
    {
        /// <summary>
        /// Copy File
        /// </summary>
        /// <param name="FileToCopy"></param>
        /// <param name="PasteFile"></param>
        public static void Copy(string FileToCopy, string PasteFile)
        {
            
            System.IO.File.Copy(FileToCopy, PasteFile);
        }
        /// <summary>
        /// Copy File
        /// </summary>
        /// <param name="FileToCopy"></param>
        /// <param name="PasteFile"></param>
        /// <param name="overwrite"></param>
        public static void Copy(string FileToCopy, string PasteFile, bool overwrite)
        {
           
            System.IO.File.Copy(FileToCopy, PasteFile, overwrite);
        }
        /// <summary>
        /// Copy byte
        /// </summary>
        /// <param name="byteToCopy"></param>
        /// <param name="PasteFile"></param>
        /// <param name="overwrite"></param>
        public static void Copy(byte[] byteToCopy, string PasteFile, bool overwrite)
        {
            
            if (overwrite)
            {
                System.IO.File.WriteAllBytes(PasteFile, byteToCopy);
            }
            else
            {
                if (System.IO.File.Exists(PasteFile))
                {

                }
                else { System.IO.File.WriteAllBytes(PasteFile, byteToCopy); }
            }
        }
        /// <summary>
        /// Copy byte
        /// </summary>
        /// <param name="byteToCopy"></param>
        /// <param name="PasteFile"></param>
        public static void Copy(byte[] byteToCopy, string PasteFile)
        {
            bool overwrite = false;
           
            if (overwrite)
            {
                System.IO.File.WriteAllBytes(PasteFile, byteToCopy);
            }
            else
            {
                if (System.IO.File.Exists(PasteFile))
                {

                }
                else { System.IO.File.WriteAllBytes(PasteFile, byteToCopy); }
            }
        }
        /// <summary>
        /// Move File to Other location
        /// </summary>
        /// <param name="FileToMove"></param>
        /// <param name="PasteFile"></param>
        public static void Move(string FileToMove, string PasteFile)
        {
           
            System.IO.File.Move(FileToMove, PasteFile);
        }
        /// <summary>
        /// Read *.properties File
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ReadProperties(string File)
        {
           
            var data = new Dictionary<string, string>();
            foreach (var row in System.IO.File.ReadAllLines(File))
            {
                try { data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray())); } catch { }
            }

            return data;

        }
        /// <summary>
        /// Get String from *.properties File
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public static string ReadProperties(string File, string Key)
        {
            
            var data = new Dictionary<string, string>();
            foreach (var row in System.IO.File.ReadAllLines(File))
            {
                try { data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray())); } catch { }
            }

            return data[Key];

        }
        /// <summary>
        /// Save *.properties File
        /// Waring! This is in beta
        /// </summary>
        /// <param name="File"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public static void WriteProperties(string File, string Key, string Value)
        {
            
            string oldfile = System.IO.File.ReadAllText(File);
            oldfile = oldfile.Replace(Key + "=" + ReadProperties(File, Key), Key + "=" + Value);
            System.IO.File.WriteAllText(File, oldfile);

        }
        /// <summary>
        /// Preview Saved *.properties File
        /// Waring! This is in beta
        /// </summary>
        /// <param name="File"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public static string PreviewWriteProperties(string File, string Key, string Value)
        {
           
            string oldfile = System.IO.File.ReadAllText(File);
            oldfile = oldfile.Replace(Key + "=" + ReadProperties(File, Key), Key + "=" + Value);
            return oldfile;

        }
        /// <summary>
        /// Check File Exist or not
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public static bool Exists(string File)
        {
           
            if (System.IO.File.Exists(File))
            {
                return true;
            }
            else { return false; }
        }
        /// <summary>
        /// Read Text
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public static string ReadAllText(string File)
        {
          
            return System.IO.File.ReadAllText(File);
        }
        /// <summary>
        /// Read Lines
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public static string ReadAllLines(string File)
        {
           
            return System.IO.File.ReadAllText(File);
        }
        /// <summary>
        /// Delete the file
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public static void DeleteFile(string File)
        {
           
            System.IO.File.Delete(File);
        }
        /// <summary>
        /// Delete a whole Folder incloud File
        /// </summary>
        /// <param name="File"></param>
        public static void DeleteFolder(string File)
        {
            
            System.IO.Directory.Delete(File, true);
        }
        /// <summary>
        /// Create a Folder
        /// </summary>
        /// <param name="FolderPath"></param>
        public static void CreateFolder(string FolderPath)
        {
          
            System.IO.Directory.CreateDirectory(FolderPath);
        }
        /// <summary>
        /// Download File
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="File"></param>
        public static void Download(string Url, string File)
        {
            
            using (var client = new WebClient())
            {
                client.DownloadFile(Url, File);
               
            }
        }
    }
}

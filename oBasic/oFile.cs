using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;

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
        public static Bitmap GetThumbnail(string File)
        {
            int THUMB_SIZE = 256;
            return GetThumbnail(
               File, THUMB_SIZE, THUMB_SIZE, ThumbnailOptions.None);
        }
        private const string IShellItem2Guid = "7E9FB0D3-919F-4307-AB2E-9B1860310C93";

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern int SHCreateItemFromParsingName(
            [MarshalAs(UnmanagedType.LPWStr)] string path,
            // The following parameter is not used - binding context.
            IntPtr pbc,
            ref Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out IShellItem shellItem);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr hObject);

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("43826d1e-e718-42ee-bc55-a1e261c37bfe")]
        internal interface IShellItem
        {
            void BindToHandler(IntPtr pbc,
                [MarshalAs(UnmanagedType.LPStruct)] Guid bhid,
                [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
                out IntPtr ppv);

            void GetParent(out IShellItem ppsi);
            void GetDisplayName(SIGDN sigdnName, out IntPtr ppszName);
            void GetAttributes(uint sfgaoMask, out uint psfgaoAttribs);
            void Compare(IShellItem psi, uint hint, out int piOrder);
        };

        internal enum SIGDN : uint
        {
            NORMALDISPLAY = 0,
            PARENTRELATIVEPARSING = 0x80018001,
            PARENTRELATIVEFORADDRESSBAR = 0x8001c001,
            DESKTOPABSOLUTEPARSING = 0x80028000,
            PARENTRELATIVEEDITING = 0x80031001,
            DESKTOPABSOLUTEEDITING = 0x8004c000,
            FILESYSPATH = 0x80058000,
            URL = 0x80068000
        }

        internal enum HResult
        {
            Ok = 0x0000,
            False = 0x0001,
            InvalidArguments = unchecked((int)0x80070057),
            OutOfMemory = unchecked((int)0x8007000E),
            NoInterface = unchecked((int)0x80004002),
            Fail = unchecked((int)0x80004005),
            ElementNotFound = unchecked((int)0x80070490),
            TypeElementNotFound = unchecked((int)0x8002802B),
            NoObject = unchecked((int)0x800401E5),
            Win32ErrorCanceled = 1223,
            Canceled = unchecked((int)0x800704C7),
            ResourceInUse = unchecked((int)0x800700AA),
            AccessDenied = unchecked((int)0x80030005)
        }

        [ComImportAttribute()]
        [GuidAttribute("bcc18b79-ba16-442f-80c4-8a59c30c463b")]
        [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IShellItemImageFactory
        {
            [PreserveSig]
            HResult GetImage(
            [In, MarshalAs(UnmanagedType.Struct)] NativeSize size,
            [In] ThumbnailOptions flags,
            [Out] out IntPtr phbm);
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct NativeSize
        {
            private int width;
            private int height;

            public int Width { set { width = value; } }
            public int Height { set { height = value; } }
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }

        public static Bitmap GetThumbnail(string fileName, int width, int height, ThumbnailOptions options)
        {
            IntPtr hBitmap = GetHBitmap(Path.GetFullPath(fileName), width, height, options);

            try
            {
                // return a System.Drawing.Bitmap from the hBitmap
                return GetBitmapFromHBitmap(hBitmap);
            }
            finally
            {
                // delete HBitmap to avoid memory leaks
                DeleteObject(hBitmap);
            }
        }

        public static Bitmap GetBitmapFromHBitmap(IntPtr nativeHBitmap)
        {
            Bitmap bmp = Bitmap.FromHbitmap(nativeHBitmap);

            if (Bitmap.GetPixelFormatSize(bmp.PixelFormat) < 32)
                return bmp;

            return CreateAlphaBitmap(bmp, PixelFormat.Format32bppArgb);
        }

        public static Bitmap CreateAlphaBitmap(Bitmap srcBitmap, PixelFormat targetPixelFormat)
        {
            Bitmap result = new Bitmap(srcBitmap.Width, srcBitmap.Height, targetPixelFormat);

            Rectangle bmpBounds = new Rectangle(0, 0, srcBitmap.Width, srcBitmap.Height);

            BitmapData srcData = srcBitmap.LockBits(bmpBounds, ImageLockMode.ReadOnly, srcBitmap.PixelFormat);

            bool isAlplaBitmap = false;

            try
            {
                for (int y = 0; y <= srcData.Height - 1; y++)
                {
                    for (int x = 0; x <= srcData.Width - 1; x++)
                    {
                        Color pixelColor = Color.FromArgb(
                            Marshal.ReadInt32(srcData.Scan0, (srcData.Stride * y) + (4 * x)));

                        if (pixelColor.A > 0 & pixelColor.A < 255)
                        {
                            isAlplaBitmap = true;
                        }

                        result.SetPixel(x, y, pixelColor);
                    }
                }
            }
            finally
            {
                srcBitmap.UnlockBits(srcData);
            }

            if (isAlplaBitmap)
            {
                return result;
            }
            else
            {
                return srcBitmap;
            }
        }

        private static IntPtr GetHBitmap(string fileName, int width, int height, ThumbnailOptions options)
        {
            IShellItem nativeShellItem;
            Guid shellItem2Guid = new Guid(IShellItem2Guid);
            int retCode = SHCreateItemFromParsingName(fileName, IntPtr.Zero, ref shellItem2Guid, out nativeShellItem);

            if (retCode != 0)
                throw Marshal.GetExceptionForHR(retCode);

            NativeSize nativeSize = new NativeSize();
            nativeSize.Width = width;
            nativeSize.Height = height;

            IntPtr hBitmap;
            HResult hr = ((IShellItemImageFactory)nativeShellItem).GetImage(nativeSize, options, out hBitmap);

            Marshal.ReleaseComObject(nativeShellItem);

            if (hr == HResult.Ok) return hBitmap;

            throw Marshal.GetExceptionForHR((int)hr);
        }
    }
    [Flags]
    public enum ThumbnailOptions
    {
        None = 0x00,
        BiggerSizeOk = 0x01,
        InMemoryOnly = 0x02,
        IconOnly = 0x04,
        ThumbnailOnly = 0x08,
        InCacheOnly = 0x10,
    }
}

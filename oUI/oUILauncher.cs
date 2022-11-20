using obedtwLAPI.oBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI
{

    /// <summary>
    /// A Class to Launch UI in obedtwLAPI
    /// </summary>
    public class oUILauncher
    {
        /// <summary>
        /// Error Report UI
        /// </summary>
        /// <param name="ErrorInfo"></param>
        /// <param name="title"></param>
        /// <param name="action"></param>
        /// <param name="TaskCode"></param>
        public static void ErrorReporter(string ErrorInfo, string title, Action action, int TaskCode)
        {
            if (APIChecker.IsUIMode())
            {
                var ErrorReporter = new oUI.ErrorReporter(ErrorInfo, title, action, TaskCode);
                ErrorReporter.Show();
            }
            else { oConsole.WriteLineColor("[Warn] UI Mode is off", ("{Warn}",ConsoleColor.Yellow), ("{off}", ConsoleColor.Red)); }
        }
        
        /// <summary>
        /// Error Report UI
        /// </summary>
        /// <param name="ErrorInfo"></param>
        /// <param name="title"></param>
        /// <param name="TaskCode"></param>
        public static void ErrorReporter(string ErrorInfo, string title, int TaskCode)
        {
            if (APIChecker.IsUIMode())
            {
                var ErrorReporter = new oUI.ErrorReporter(ErrorInfo, title, TaskCode);
                ErrorReporter.Show();
            }
            else { oConsole.WriteLineColor("[Warn] UI Mode is off", ("{Warn}", ConsoleColor.Yellow), ("{off}", ConsoleColor.Red)); }
        }
        /// <summary>
        /// Force Open Error Report UI
        /// </summary>
        /// <param name="ErrorInfo"></param>
        /// <param name="title"></param>
        /// <param name="action"></param>
        /// <param name="TaskCode"></param>
        public static void ForceErrorReporter(string ErrorInfo, string title, Action action, int TaskCode)
        {
            
                var ErrorReporter = new oUI.ErrorReporter(ErrorInfo, title, action, TaskCode);
            oConsole.WriteLineColor("[Warn] Force UI is on", ("{Warn}", ConsoleColor.Yellow), ("{on}", ConsoleColor.Red));
            ErrorReporter.Show();
        }
        
        
        /// <summary>
        /// Force Open Error Report UI
        /// </summary>
        /// <param name="ErrorInfo"></param>
        /// <param name="title"></param>
        /// <param name="TaskCode"></param>
        public static void ForceErrorReporter(string ErrorInfo, string title, int TaskCode)
        {
           
            var ErrorReporter = new oUI.ErrorReporter(ErrorInfo, title, TaskCode);
            oConsole.WriteLineColor("[Warn] Force UI is on", ("{Warn}", ConsoleColor.Yellow), ("{on}", ConsoleColor.Red));
            ErrorReporter.Show();
        }
       /// <summary>
       /// Set Text From Lang File
       /// </summary>
       /// <param name="obj"></param>
       /// <param name="LangFile"></param>
        public static void UpdateLang(System.Windows.Forms.Control obj, string LangFile)
        {
                obj.Text = obj.Text.Replace(obj.Text, oFile.ReadProperties(LangFile, obj.Text));
        }
        

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI
{
    /// <summary>
    /// A Class with Waiting Task
    /// </summary>
    public class oTasks
    {
        /// <summary>
        /// Do Action with Async and Waiting Time
        /// </summary>
        /// <param name="RunTask"></param>
        /// <param name="WaitMillSeconed"></param>
        public static async void DoAction(Action RunTask,int WaitMillSeconed,int TaskCode)
        {
            await Task.Delay(WaitMillSeconed);
            try { RunTask(); } catch (Exception ex) { oConsole.WriteLineColor("Error on Task #" + TaskCode + " Error Info: " + ex.Message, ("Error", ConsoleColor.Red), ("Task #" + TaskCode, ConsoleColor.Red)); oUILauncher.ErrorReporter(" Error Info: " + ex.Message, "Error on Task #" + TaskCode,RunTask,TaskCode); }
        }
        /// <summary>
        /// Do Action Async
        /// </summary>
        /// <param name="RunTask"></param>
        public static async void DoAction(Action RunTask,int TaskCode)
        {
            await Task.Delay(1);
            try { RunTask(); } catch(Exception ex) { oConsole.WriteLineColor("Error on Task #"+TaskCode+" Error Info: "+ex.Message,("Error",ConsoleColor.Red), ("Task #"+TaskCode, ConsoleColor.Red)); }
            
        }
        

    }
   
}

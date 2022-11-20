using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace obedtwLAPI.oBasic
{
    
        public class bedh
        {
        /// <summary>
        /// Path to Cd Path
        /// </summary>
            public static string Rroot;
            public List<String> files = new List<String>();
        /// <summary>
        /// A Loader for Legency bedh Console.
        /// </summary>
        /// <param name="args"></param>
            public static void Bedh(params string[] args)
            {
                 
                
                Rroot = AppDomain.CurrentDomain.BaseDirectory;
                try
                {
                    try
                    {
                        if (System.IO.File.Exists(args[0]))
                        {
                            foreach (string command in System.IO.File.ReadAllLines(args[0]))
                            {
                                SendCommand(command);
                            }
                            Environment.Exit(0);

                        }
                    }
                    catch { }
                }
                catch { }
                SendCommand("title obedtwL API Console BETA");
                SendCommand("echo obedtwL API b1: Beta");
                SendCommand("app startup-service config=09a2f5");
                Console.ResetColor();
                System.IO.Directory.CreateDirectory("C:\\BeBased");
                if (!System.IO.File.Exists("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                {
                    SendCommand("echon Welcome to obedtwL Console (Lengency) Based on ");
                    Console.ForegroundColor = ConsoleColor.Green; ;
                    SendCommand("echo obedtwLAPI");
                    Console.ResetColor();
                    SendCommand("echon Enter a New Password for " + Environment.UserName + ":");
                    System.IO.File.WriteAllText("C:\\BeBased\\" + Environment.UserName + ".passwd", Console.ReadLine());

                }
                SendCommand("app startup-service config=7a5f3s");
                do
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    SendCommand("echon " + Environment.MachineName + "@" + Environment.UserName + " ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    SendCommand("echon " + Rroot);
                    Console.ResetColor();
                    SendCommand("echon $ ");
                    SendCommand(Console.ReadLine());
                } while (true);
            }
        /// <summary>
        /// A Lengency Command
        /// </summary>
        /// <param name="terminal_Command"></param>
            public static void SendCommand(string terminal_Command)
            {
                 
               
                //terminal_Command = terminal_Command.ToLower();
                try
                {
                    if (terminal_Command == "exit")
                    {
                        Environment.Exit(0);
                    }
                    else if (terminal_Command == "")
                    {
                        return;
                    }
                    else if (terminal_Command == "cmd")
                    {
                        SendCommand("run cmd");
                    }
                    else if (terminal_Command == "powershell")
                    {
                        SendCommand("run powershell");
                    }
                    else if (terminal_Command == "app startup-service config=09a2f5")
                    {
                        if (!System.IO.File.Exists("C:\\BeBased\\app\\config09a2f5.KERNEL"))
                        {
                            System.IO.File.WriteAllText("C:\\BeBased\\app\\config09a2f5.KERNEL", "");
                        }
                        foreach (string StartupP in System.IO.File.ReadLines("C:\\BeBased\\app\\config09a2f5.KERNEL"))
                        {
                            SendCommand(StartupP);
                        }
                    }
                    else if (terminal_Command == "app startup-service config=7a5f3s")
                    {
                        if (!System.IO.File.Exists("C:\\BeBased\\app\\config7a5f3s.KERNEL"))
                        {
                            System.IO.File.WriteAllText("C:\\BeBased\\app\\config7a5f3s.KERNEL", "");
                        }
                        foreach (string StartupP in System.IO.File.ReadLines("C:\\BeBased\\app\\config7a5f3s.KERNEL"))
                        {
                            SendCommand(StartupP);
                        }
                    }
                    else if (terminal_Command == "help")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        SendCommand("echon b1:beta - HELP              ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        SendCommand("echo  X");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        SendCommand("echo exit                          ");

                        SendCommand("echo help                          ");
                        SendCommand("echo sudo                          ");
                        SendCommand("echo clear                         ");
                        SendCommand("echo dir                           ");
                        SendCommand("echo dir /s                        ");
                        SendCommand("echo pause                         ");

                        SendCommand("echo datapack                      ");

                        SendCommand("echo     datapack help             ");

                        SendCommand("echo     datapack run              ");

                        SendCommand("echo dev-mode                      ");
                    SendCommand("echo UI-mode                      ");
                    SendCommand("echo cd                            ");

                        SendCommand("echo rm                            ");

                        SendCommand("echo rmdir                         ");

                        SendCommand("echo run                           ");

                        SendCommand("echo app                           ");

                        SendCommand("echo     app install               ");

                        SendCommand("echo     app help                  ");

                        SendCommand("echo     app run                   ");

                        SendCommand("echo     app remove                ");
                        SendCommand("echo     app list                  ");
                        SendCommand("echo     app add-startup-service   ");
                        SendCommand("echo     app startup-service list  ");
                        SendCommand("echo     app remove-startup-service");
                        SendCommand("echo echo                          ");
                        SendCommand("echo cmd                           ");
                        SendCommand("echo powershell                    ");
                        SendCommand("echo echon                         ");
                        SendCommand("echo passwd                        ");
                        SendCommand("echo logout                        ");
                        SendCommand("echo cd\\                           ");
                        SendCommand("echo rcd                           ");
                        SendCommand("echo title                         ");
                        SendCommand("echo ShowInfo                      ");
                    SendCommand("echo mkdir                         ");
                        SendCommand("echo                               ");
                        SendCommand("echo                               ");
                        SendCommand("echon BeBased API b1:beta  -   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        SendCommand("echo help ");
                        Console.ResetColor();
                        return;
                    }
                    else if (terminal_Command == "passwd")
                    {

                        SendCommand("echon [passwd] Enter password old for " + Environment.UserName + ":");
                        if (Console.ReadLine() == System.IO.File.ReadAllText("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                        {
                            SendCommand("echo   ");
                            SendCommand("echon [passwd] Enter new password for " + Environment.UserName + ":");

                            System.IO.File.WriteAllText("C:\\BeBased\\" + Environment.UserName + ".passwd", Console.ReadLine());
                            SendCommand("echo Sucessful to change Passoword for " + Environment.UserName);

                        }
                        else
                        {
                            SendCommand("echon [passwd] Wrong password please Retry:");
                            if (Console.ReadLine() == System.IO.File.ReadAllText("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                            {
                                SendCommand("echo   ");
                                SendCommand("echon [passwd] Enter new password for " + Environment.UserName + ":");

                                System.IO.File.WriteAllText("C:\\BeBased\\" + Environment.UserName + ".passwd", Console.ReadLine());
                                SendCommand("echo Sucessful to change Passoword for " + Environment.UserName);
                            }
                            else
                            {
                                SendCommand("echon [passed] Wrong password please Retry:");
                                if (Console.ReadLine() == System.IO.File.ReadAllText("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                                {
                                    SendCommand("echo   ");
                                    SendCommand("echon [passwd] Enter new password for " + Environment.UserName + ":");

                                    System.IO.File.WriteAllText("C:\\BeBased\\" + Environment.UserName + ".passwd", Console.ReadLine());
                                    SendCommand("echo Sucessful to change Passoword for " + Environment.UserName);
                                }
                            }
                        }

                    }
                    else if (terminal_Command == "clear")
                    {
                        Console.Clear();
                    }
                    else if (terminal_Command == "pause")
                    {
                        Console.ReadKey();
                    }
                    else if (terminal_Command == "app")
                    {
                        SendCommand("echo app");
                        SendCommand("echo     app install");
                        SendCommand("echo     app help");
                        SendCommand("echo     app run");
                        SendCommand("echo     app remove");
                        SendCommand("echo     app add-startup-service");
                        SendCommand("echo     app startup-service list");
                        SendCommand("echo     app remove-startup-service");
                    }
                    else if (terminal_Command == "app help")
                    {
                        SendCommand("echo app");
                        SendCommand("echo     app install");
                        SendCommand("echo     app help");
                        SendCommand("echo     app run");
                        SendCommand("echo     app remove");
                        SendCommand("echo     app add-startup-service");
                        SendCommand("echo     app startup-service list");
                        SendCommand("echo     app remove-startup-service");
                    }
                    else if (terminal_Command == "datapack")
                    {
                        try { SendCommand("echo Datapack: running on BeBased v1, datapack ver: " + System.IO.File.ReadAllText("C:\\BeBased\\datapackVER")); } catch { Console.WriteLine("Datapack: Not Installed"); }
                    }
                    else if (terminal_Command == "cd\\")
                    {
                        Rroot = "C:\\";
                    }
                    else if (terminal_Command == "dir")
                    {
                        foreach (string file in System.IO.Directory.GetFiles(Rroot))
                        {
                            Console.WriteLine(file);
                        }
                    }
                    else if (terminal_Command == "dir /s")
                    {
                        DirSearch(Rroot);
                    }
                    else if (terminal_Command == "logout")
                    {
                        System.Windows.Forms.Application.Restart();
                        Environment.Exit(0);
                    }
                    else if (terminal_Command == "dev-mode")
                    {
                    oData.ToggleDataBool("DebugMode");
                     
                    }
                else if (terminal_Command == "ui-mode")
                {
                    oData.ToggleDataBool("UIMode");

                }
                else if (terminal_Command == "showinfo")
                {
                    Info.ShowInfo();

                }
                else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "cd")
                    {
                        if (System.IO.Directory.Exists(Rroot + "\\" + terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1)))
                        { Rroot = Rroot + "" + terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1) + "\\"; }
                        else { Console.ForegroundColor = ConsoleColor.Red; SendCommand("echon E:"); Console.ResetColor(); SendCommand("echon Cannot found dir " + Rroot + "" + terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1) + "\n"); }

                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "rcd")
                    {
                        if (System.IO.Directory.Exists(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1)))
                        { Rroot = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1) + "\\"; }
                        else { Console.ForegroundColor = ConsoleColor.Red; SendCommand("echon E:"); Console.ResetColor(); SendCommand("echon Cannot found dir " + terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1) + "\n"); }

                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "download")
                    {
                        try
                        {
                            string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                            using (var client = new WebClient())
                            {
                                SendCommand("echo Downloading Files at " + FILENAME.Substring(0, terminal_Command.IndexOf(" ")));
                                client.DownloadFile(FILENAME.Substring(0, terminal_Command.IndexOf(" ")), terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1));



                            }

                        }
                        catch
                        {
                            SendCommand("echo Unknow Error");

                        }





                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "rm")
                    {
                        System.IO.File.Delete(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1));
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "sudo")
                    {
                        System.IO.File.WriteAllText("C:\\BeBased\\sudo.txt", terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1).Replace(" && ", "\n"));
                        Process proc = new Process();
                        proc.StartInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
                        proc.StartInfo.Arguments = "C:\\BeBased\\sudo.txt";
                        proc.StartInfo.Verb = "runas";
                        //proc.StartInfo.UseShellExecute = false;

                        proc.StartInfo.WorkingDirectory = Rroot;
                        SendCommand("echon [sudo] Enter password for " + Environment.UserName + ":");
                        if (Console.ReadLine() == System.IO.File.ReadAllText("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                        {
                            proc.Start();
                            proc.WaitForExit();
                        }
                        else
                        {
                            SendCommand("echon [sudo] Wrong password please Retry:");
                            if (Console.ReadLine() == System.IO.File.ReadAllText("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                            {
                                proc.Start();
                                proc.WaitForExit();
                            }
                            else
                            {
                                SendCommand("echon [sudo] Wrong password please Retry:");
                                if (Console.ReadLine() == System.IO.File.ReadAllText("C:\\BeBased\\" + Environment.UserName + ".passwd"))
                                {
                                    proc.Start();
                                    proc.WaitForExit();
                                }
                            }
                        }

                    }

                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "cp")
                    {
                        try
                        {
                            string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                            System.IO.File.Copy(FILENAME.Substring(0, terminal_Command.IndexOf(" ")), terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1));
                        }
                        catch
                        {
                            SendCommand("echo Overwrite file? [y/n]"); if (Console.ReadLine() == "y")
                            {
                                string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                                System.IO.File.Copy(FILENAME.Substring(0, terminal_Command.IndexOf(" ")), terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1), true);
                            }
                            else { }
                        }
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "run")
                    {
                        try
                        {
                            string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                            System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = FILENAME.Substring(0, terminal_Command.IndexOf(" ")); proc.StartInfo.UseShellExecute = false; proc.StartInfo.WorkingDirectory = Rroot; proc.StartInfo.Arguments = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1); proc.Start(); proc.WaitForExit();
                        }
                        catch { System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1); proc.StartInfo.UseShellExecute = false; proc.StartInfo.WorkingDirectory = Rroot; proc.Start(); proc.WaitForExit(); }
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "datapack")
                    {
                        try
                        {
                            SendCommand("echo Datapack Loader b1: BETA");
                            string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                            System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = "C:\\BeBased\\datapack.exe"; proc.StartInfo.Arguments = FILENAME.Substring(0, terminal_Command.IndexOf(" ")); proc.Start(); proc.WaitForExit();
                        }
                        catch { Console.ForegroundColor = ConsoleColor.Red; SendCommand("echo Datapack: Datapack lib Not Found!"); Console.ResetColor(); }
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "app")
                    {

                        try
                        {
                            if (!System.IO.File.Exists("C:\\BeBased\\app\\applist.conf"))
                            {
                                System.IO.Directory.CreateDirectory("C:\\BeBased\\app");
                                System.IO.File.WriteAllText("C:\\BeBased\\app\\applist.conf", "");
                            }

                            string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                            //if (FILENAME.Substring(0,FILENAME.IndexOf(" ")+1)=="install")

                            if (terminal_Command.Substring(0, "app run".Length) == "app run")
                            {
                                foreach (string appname in System.IO.File.ReadAllLines("C:\\BeBased\\app\\applist.conf"))
                                {
                                    if (appname == terminal_Command.Substring("app run".Length + 1))
                                    {
                                        try
                                        {
                                            System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = "C:\\BeBased\\app\\" + appname + "\\" + appname + ".exe"; proc.StartInfo.WorkingDirectory = "C:\\BeBased\\app\\" + appname + "\\"; proc.StartInfo.UseShellExecute = false; proc.StartInfo.Arguments = terminal_Command.Substring("app run ".Length); proc.Start(); proc.WaitForExit();
                                        }
                                        catch
                                        {
                                            System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = "C:\\BeBased\\app\\" + appname + "\\" + appname + ".exe"; proc.StartInfo.WorkingDirectory = "C:\\BeBased\\app\\" + appname + "\\"; proc.StartInfo.UseShellExecute = false; proc.Start(); proc.WaitForExit();
                                        }

                                        return;
                                    }
                                }
                                SendCommand("echo App not Found!");

                            }
                            else if (terminal_Command.Substring(0, "app get".Length) == "app get")
                            {
                                SendCommand("download " + terminal_Command.Substring("app get".Length) + " AppGetTemp");
                                SendCommand("app install " + AppDomain.CurrentDomain.BaseDirectory + "AppGetTemp");
                                return;


                            }
                            else if (terminal_Command.Substring(0, "app list".Length) == "app list")
                            {
                                SendCommand("echo App list:\n");
                                foreach (string appname in System.IO.File.ReadAllLines("C:\\BeBased\\app\\applist.conf"))
                                {
                                    SendCommand("echo " + appname);
                                }
                                return;


                            }
                            else if (terminal_Command == "app startup-service list")
                            {
                                if (!System.IO.File.Exists("C:\\BeBased\\app\\config09a2f5.KERNEL"))
                                {
                                    System.IO.File.WriteAllText("C:\\BeBased\\app\\config09a2f5.KERNEL", "");
                                }
                                foreach (string StartupP in System.IO.File.ReadLines("C:\\BeBased\\app\\config09a2f5.KERNEL"))
                                {
                                    SendCommand("echo " + StartupP);
                                }
                                if (!System.IO.File.Exists("C:\\BeBased\\app\\config7a5f3s.KERNEL"))
                                {
                                    System.IO.File.WriteAllText("C:\\BeBased\\app\\config7a5f3s.KERNEL", "");
                                }
                                foreach (string StartupP in System.IO.File.ReadLines("C:\\BeBased\\app\\config7a5f3s.KERNEL"))
                                {
                                    SendCommand("echo " + StartupP);
                                }
                            }

                            else if (terminal_Command.Substring(0, "app remove-startup-service".Length) == "app remove-startup-service")
                            {
                                System.IO.File.WriteAllText("C:\\BeBased\\app\\config7a5f3s.KERNEL", System.IO.File.ReadAllText("C:\\BeBased\\app\\config7a5f3s.KERNEL").Replace(terminal_Command.Substring("app remove-startup-service".Length + 1) + "\n", ""));


                            }
                            else if (terminal_Command.Substring(0, "app add-startup-service".Length) == "app add-startup-service")
                            {
                                System.IO.File.WriteAllText("C:\\BeBased\\app\\config7a5f3s.KERNEL", System.IO.File.ReadAllText("C:\\BeBased\\app\\config7a5f3s.KERNEL") + terminal_Command.Substring("app add-startup-service".Length + 1) + "\n");


                            }
                            else if (terminal_Command.Substring(0, "app remove".Length) == "app remove")
                            {
                                SendCommand("echo Removing " + FILENAME.Substring(FILENAME.IndexOf(" ") + 1) + "...");
                                foreach (string appname in System.IO.File.ReadAllLines("C:\\BeBased\\app\\applist.conf"))
                                {
                                    if (appname == FILENAME.Substring(FILENAME.IndexOf(" ") + 1))
                                    {
                                        SendCommand("rmdir " + "C:\\BeBased\\app\\" + appname + "\\");
                                        System.IO.File.WriteAllText("C:\\BeBased\\app\\applist.conf", System.IO.File.ReadAllText("C:\\BeBased\\app\\applist.conf").Replace(appname + "\n", ""));
                                        SendCommand("echo Removed " + FILENAME.Substring(FILENAME.IndexOf(" ") + 1) + " Package");
                                        return;
                                    }
                                }
                                SendCommand("echo App not Found!");

                            }

                            if (terminal_Command.Substring(0, "app import ".Length) == "app import ")
                            {
                                string appname = terminal_Command.Substring("app import".Length + 1);
                                string appdir = appname.Substring(terminal_Command.IndexOf(" ") + 1);
                                Console.WriteLine("App name : " + appname.Replace(appdir, ""));
                                Console.WriteLine("App Dir : " + appdir);
                                System.IO.File.WriteAllText(appdir + "\\appname.conf", appname.Replace(appdir, ""));
                                if (!System.IO.File.Exists(appdir + "\\" + appname.Replace(appdir, "") + ".exe"))
                                { Console.WriteLine("error unable to found main program: " + appdir + "\\" + appname.Replace(appdir, "") + ".exe" + " Not Exist"); return; }
                                Console.WriteLine("Done! Config ");
                            }
                            else if (terminal_Command.Substring(0, 11) == "app install")
                            {
                                SendCommand("echo installing Package...");
                                System.IO.Directory.CreateDirectory("C:\\BeBased\\app\\Temp");
                                System.IO.Directory.Delete("C:\\BeBased\\app\\Temp", true);
                                System.IO.Directory.CreateDirectory("C:\\BeBased\\app\\Temp");
                                SendCommand("echo installing Package...");
                                ZipFile.ExtractToDirectory(Rroot + FILENAME.Substring(FILENAME.IndexOf(" ") + 1), "C:\\BeBased\\app\\Temp");
                                ZipFile.ExtractToDirectory(Rroot + FILENAME.Substring(FILENAME.IndexOf(" ") + 1), "C:\\BeBased\\app\\" + System.IO.File.ReadAllText("C:\\BeBased\\app\\Temp\\appname.conf"));
                                System.IO.File.WriteAllText("C:\\BeBased\\app\\applist.conf", System.IO.File.ReadAllText("C:\\BeBased\\app\\applist.conf").Replace(System.IO.File.ReadAllText("C:\\BeBased\\app\\Temp\\appname.conf") + "\n", "") + System.IO.File.ReadAllText("C:\\BeBased\\app\\Temp\\appname.conf") + "\n");
                                SendCommand("echo Installed Package " + System.IO.File.ReadAllText("C:\\BeBased\\app\\Temp\\appname.conf"));
                            }
                        }
                        catch (Exception e) { Console.ForegroundColor = ConsoleColor.Red; SendCommand("echo App: App package broken! or error : " + e.Message); Console.ResetColor(); }
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "echo")
                    {
                        Console.WriteLine(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1));
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "echon")
                    {
                        Console.Write(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1));
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "title")
                    {
                        Console.Title = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "rmdir")
                    {
                        System.IO.Directory.Delete(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1), true);
                    }
                    else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "mkdir")
                    {
                        System.IO.Directory.CreateDirectory(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1));
                    }
                else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "start")
                {
                    Console.WriteLine(terminal_Command.Substring(terminal_Command.IndexOf(" "), terminal_Command.Substring(terminal_Command.IndexOf(" ") ).IndexOf(" ")) + 1);
                    Console.WriteLine(terminal_Command.Substring(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1).IndexOf(" ")));
                    System.Diagnostics.Process.Start(terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1, terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1).IndexOf(" ")),terminal_Command.Substring(terminal_Command.Substring(terminal_Command.IndexOf(" ")).IndexOf(" ")));
                }
                /*
                else if (terminal_Command.Substring(0, terminal_Command.IndexOf(" ")) == "datapack")
                {
                    try
                    {
                        string FILENAME = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1);
                        if (FILENAME.Substring(0, terminal_Command.IndexOf(" "))=="install") terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1); proc.Start(); proc.WaitForExit();
                    }
                    catch { System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = terminal_Command.Substring(terminal_Command.IndexOf(" ") + 1); proc.Start(); proc.WaitForExit(); }
                }*/
                else { System.Diagnostics.Process.Start(terminal_Command); }

                }
                catch (Exception e)
                {
                    try
                    {
                        try
                        {
                            try
                            {

                                if (!System.IO.File.Exists("C:\\BeBased\\app\\applist.conf"))
                                {
                                    System.IO.Directory.CreateDirectory("C:\\BeBased\\app");
                                    System.IO.File.WriteAllText("C:\\BeBased\\app\\applist.conf", "");
                                }


                                //if (FILENAME.Substring(0,FILENAME.IndexOf(" ")+1)=="install")


                                foreach (string appname in System.IO.File.ReadAllLines("C:\\BeBased\\app\\applist.conf"))
                                {
                                    if (appname == terminal_Command)
                                    {
                                        try
                                        {
                                            System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = "C:\\BeBased\\app\\" + appname + "\\" + appname + ".exe"; proc.StartInfo.WorkingDirectory = "C:\\BeBased\\app\\" + appname + "\\"; proc.StartInfo.UseShellExecute = false; proc.StartInfo.Arguments = terminal_Command.Substring("app run ".Length); proc.Start(); proc.WaitForExit();
                                        }
                                        catch
                                        {
                                            System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = "C:\\BeBased\\app\\" + appname + "\\" + appname + ".exe"; proc.StartInfo.WorkingDirectory = "C:\\BeBased\\app\\" + appname + "\\"; proc.StartInfo.UseShellExecute = false; proc.Start(); proc.WaitForExit();
                                        }

                                        return;
                                    }
                                }



                            }
                            catch { }
                            try
                            {

                                string FILENAME = terminal_Command;
                                System.Diagnostics.Process proc = new System.Diagnostics.Process(); proc.StartInfo.FileName = "C:\\BeBased\\datapack.exe"; proc.StartInfo.Arguments = FILENAME.Substring(0, terminal_Command.IndexOf(" ")); proc.Start(); proc.WaitForExit();
                            }
                            catch { Console.ForegroundColor = ConsoleColor.Red; Console.ResetColor(); }
                            if (System.IO.File.Exists("C:\\BeBased\\datapackrun.log"))
                            { System.IO.File.Delete("C:\\BeBased\\datapackrun.log"); return; }
                        }
                        catch { }
                    }
                    catch { Console.ForegroundColor = ConsoleColor.Red; Console.Write("E:"); Console.ResetColor(); Console.Write(" " + e.Message + "\n"); }
                }
            }
        /// <summary>
        /// Get Dir File & subdir File
        /// </summary>
        /// <param name="sDir"></param>
            static void DirSearch(string sDir)
            {
                 
                
                try
                {
                    foreach (string f in System.IO.Directory.GetFiles(sDir))
                    {

                        Console.WriteLine(f);
                    }
                    foreach (string d in System.IO.Directory.GetDirectories(sDir))
                    {
                        Console.WriteLine(d + "           [DIR]");
                        DirSearch(d + "\\");
                    }
                }
                catch (System.Exception excpt)
                {
                    Console.WriteLine(excpt);
                }
            }
        }
        
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace obedtwLAPI
{
    /// <summary>
    /// A Class For Console Stuff
    /// </summary>
    public class oConsole
    {
        /// <summary>
        /// A Console History when using This Class
        /// </summary>
        public static string ConsoleHistory="";
        /// <summary>
        /// A Console Write with Advance Color
        /// Usage: str(string), {your word in str}, Your Color
        /// </summary>
        public static void WriteColor(string str, params (string substring, ConsoleColor color)[] colors)
        {
            var words = Regex.Split(str, @"( )");

            foreach (var word in words)
            {
                (string substring, ConsoleColor color) cl = colors.FirstOrDefault(x => x.substring.Equals("{" + word + "}"));
                if (cl.substring != null)
                {
                    Console.ForegroundColor = cl.color;
                    Console.Write(cl.substring.Substring(1, cl.substring.Length - 2));
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(word);
                }
            }
            ConsoleHistory = ConsoleHistory + str;
        }
        /// <summary>
        /// A Console WriteLine with Advance Color
        /// Usage: str(string), {your word in str}, Your Color
        /// </summary>
        public static void WriteLineColor(string str, params (string substring, ConsoleColor color)[] colors)
        {
            var words = Regex.Split(str, @"( )");

            foreach (var word in words)
            {
                (string substring, ConsoleColor color) cl = colors.FirstOrDefault(x => x.substring.Equals("{" + word + "}"));
                if (cl.substring != null)
                {
                    Console.ForegroundColor = cl.color;
                    Console.Write(cl.substring.Substring(1, cl.substring.Length - 2));
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(word);
                }
            }
            Console.WriteLine();
            ConsoleHistory = ConsoleHistory + str+"\\";
        }
        /// <summary>
        /// A Moded Console.WriteLine()
        /// </summary>
        /// <param name="Text"></param>
        public static void WriteLine(object Text, params object[] arg)
        {
            ConsoleHistory = ConsoleHistory + Text + "\n";
            Console.WriteLine(Text.ToString(),arg);
        }
        /// <summary>
        /// A Moded Console.WriteLine()
        /// </summary>
        /// <param name="Text"></param>
        public static void WriteLine(object Text)
        {
            ConsoleHistory = ConsoleHistory + Text + "\n";
            Console.WriteLine(Text.ToString());
        }
        /// <summary>
        /// A Moded Console.Write()
        /// </summary>
        /// <param name="Text"></param>
        public static void Write(object Text, params object[] arg)
        {
            ConsoleHistory = ConsoleHistory + Text + "";
            Console.Write(Text.ToString(), arg);
        }
        /// <summary>
        /// A Moded Console.Write()
        /// </summary>
        /// <param name="Text"></param>
        public static void Write(object Text)
        {
            ConsoleHistory = ConsoleHistory + Text + "";
            Console.WriteLine(Text.ToString());
        }
        /// <summary>
        /// A Console UI
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string ConsoleMenu(string[] opt, string title)
        {
            return ConsoleMenu(opt, title ,"");
        }
        /// <summary>
        /// A Console UI
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="title"></param>
        /// <param name="Info"></param>
        /// <returns></returns>
        public static string ConsoleMenu(string[] opt, string title, string Info)
        {
            int tmp = 0;
            int list = 1;

            string ass = "";
            foreach (var op in opt)
            {
                if (tmp == 0)
                {
                    ass = op;
                }
                tmp = tmp + 1;
            }
            list = 1 + tmp;
            int now = 1;
            Console.Clear();
            Console.ResetColor();
            WriteLine("                                                            ");
            WriteLine(title);
            WriteLine("                                                            ");
            tmp = 1;
            foreach (var op in opt)
            {
                if (tmp == now)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    WriteLine(op);
                    Console.ResetColor();
                }
                else { WriteLine(op ); }
                tmp = tmp + 1;
            }


            Console.ResetColor();
            WriteLine("                                                            " );
            WriteLine(Info );
            WriteLine("                                                            " );
            do
            {

                ConsoleKey ke = Console.ReadKey().Key;
                tmp = 1;
                if (ke == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return ass;
                }
                else if (ke == ConsoleKey.DownArrow)
                {
                    if (now == list - 1)
                    {

                    }
                    else { now = now + 1; }

                    Console.Clear();
                    Console.ResetColor();
                    WriteLine("                                                            " );
                    WriteLine(title );
                    WriteLine("                                                            " );
                    Console.ResetColor();
                    foreach (var op in opt)
                    {
                        if (tmp == now)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            WriteLine(op );
                            Console.ResetColor();
                            ass = op;
                        }
                        else { WriteLine(op ); }
                        tmp = tmp + 1;
                    }
                    Console.ResetColor();
                    WriteLine("                                                            " );
                    WriteLine(Info );
                    WriteLine("                                                            " );

                }
                else if (ke == ConsoleKey.UpArrow)
                {

                    if (now == 1)
                    { }
                    else { now = now - 1; }

                    Console.Clear();
                    Console.ResetColor();
                    WriteLine("                                                            " );
                    WriteLine(title );
                    WriteLine("                                                            " );
                    foreach (var op in opt)
                    {
                        if (tmp == now)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            WriteLine(op );
                            Console.ResetColor();
                            ass = op;
                        }
                        else { WriteLine(op ); }
                        tmp = tmp + 1;
                    }
                    WriteLine("                                                            " );
                    WriteLine(Info );
                    WriteLine("                                                            " );

                }

            } while (true);

            
        }

    }
}

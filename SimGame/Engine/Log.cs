using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Engine
{
    public static class Log
    {
        public static void Normal(string msg)
        {
            Console.WriteLine($"[LOG] {msg}");
        }

        public static void Info(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[INFO] {msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Warning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARN] {msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] {msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

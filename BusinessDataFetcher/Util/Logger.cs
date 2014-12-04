using System;

namespace BusinessDataFetcher
{
    internal class Logger
    {
        public static bool Enabled = false;

        public static int Init()
        {
            Enabled = true;
            return NativeMethods.AllocConsole();
        }

        public static int Dispose()
        {
            if (Enabled)
            {
                Enabled = false;
                return NativeMethods.FreeConsole();
            }
            return 0;
        }

        public static void WriteLine(string s)
        {
            if (Enabled)
                Console.WriteLine(s);
        }

        public static void Write(string s)
        {
            if (Enabled)
                Console.Write(s);
        }

        public static void WriteLine(string s, ConsoleColor c)
        {
            if (Enabled)
            {
                Console.ForegroundColor = c;
                Console.WriteLine(s);
                Console.ResetColor();
            }
        }

        public static void Write(string s, ConsoleColor c)
        {
            if (Enabled)
            {
                Console.ForegroundColor = c;
                Console.Write(s);
                Console.ResetColor();
            }
        }
    }
}
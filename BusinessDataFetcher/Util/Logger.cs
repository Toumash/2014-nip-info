namespace BusinessDataFetcher
{
    using System;

    internal class Logger
    {
        #region Fields

        public static bool Enabled = false;

        #endregion Fields

        #region Methods

        public static int Dispose()
        {
            if (Enabled)
            {
                Enabled = false;
                return NativeMethods.FreeConsole();
            }
            return 0;
        }

        public static int Init()
        {
            Enabled = true;
            return NativeMethods.AllocConsole();
        }

        public static void Write(string s)
        {
            if (Enabled)
                Console.Write(s);
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

        public static void WriteLine(string s)
        {
            if (Enabled)
                Console.WriteLine(s);
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

        #endregion Methods
    }
}
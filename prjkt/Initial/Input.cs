using System;

namespace Initial
{
    class Input
    {
        public static int Horizontal
        {
            get
            {
                int _axesValue = Console.KeyAvailable && Console.ReadKey(true).Key.Equals(ConsoleKey.RightArrow) ? 1 :
                   Console.KeyAvailable && Console.ReadKey(true).Key.Equals(ConsoleKey.LeftArrow) ? -1 : 0;

                return _axesValue;
            }
        }

        public static int Vertical
        {
            get
            {
                int _axesValue = Console.KeyAvailable && Console.ReadKey(true).Key.Equals(ConsoleKey.UpArrow) ? 1 :
                   Console.KeyAvailable && Console.ReadKey(true).Key.Equals(ConsoleKey.DownArrow) ? -1 : 0;

                return _axesValue;
            }
        }
    }
}

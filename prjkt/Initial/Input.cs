using System;

namespace Initial
{
    class Input
    {
        public static int _h;
        public static int _v;

        public static int InputValue
        {
            get
            {
                var _key = Console.ReadKey(true).Key;

                int _axesValue = _key.Equals(ConsoleKey.RightArrow) || _key.Equals(ConsoleKey.UpArrow) ? 1 :
                 _key.Equals(ConsoleKey.LeftArrow) || _key.Equals(ConsoleKey.DownArrow) ? -1 : 0;

                if (_key.Equals(ConsoleKey.RightArrow) || _key.Equals(ConsoleKey.LeftArrow))
                    _h = _axesValue;

                if (_key.Equals(ConsoleKey.UpArrow) || _key.Equals(ConsoleKey.DownArrow))
                    _v = _axesValue;

                return _axesValue;

            }
        }

        public static void ResetInput()
        {
            _h = 0;
            _v = 0;
        }
    }
}

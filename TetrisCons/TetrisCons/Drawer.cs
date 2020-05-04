using System;

namespace TetrisCons
{
    public static class Drawer
    {
        public const char DEFAULT_SYMBOL = '*';

        public static void DrawPoint(int x, int y, char sym = DEFAULT_SYMBOL)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(sym);
            Console.SetCursorPosition(0, 0);
        }

        public static void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }
    }
}
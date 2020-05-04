using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class ConsoleDrawer : IDrawer
    {
        public void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('o');
            Console.SetCursorPosition(0,0);
        }

        public void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }

        public void InitGameField()
        {
            Console.Title = "Tetris";
            Console.SetWindowSize(GameField.Width, GameField.Height);
            Console.SetBufferSize(GameField.Width, GameField.Height);
        }

        public void WriteGameOver()
        {
            Console.SetCursorPosition(GameField.Width / 2 - 8, GameField.Height / 2 - 2);
            Console.WriteLine("G A M E   O V E R");
        }
    }
}

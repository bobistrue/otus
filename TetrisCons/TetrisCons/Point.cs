using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class Point
    {
        int x;
        int y;
        char figure;

        public Point(int x, int y, char f)
        {
            this.x = x;
            this.y = y;
            this.figure = f;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.figure);
        }
    }
}

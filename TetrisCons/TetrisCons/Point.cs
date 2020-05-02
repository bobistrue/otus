using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class Point
    {
        public int x;
        public int y;
        public char f;

        public Point(int x, int y, char f)
        {
            this.x = x;
            this.y = y;
            this.f = f;
        }

        public Point()
        {

        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.f);
        }
    }
}

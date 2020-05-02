using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    public class Point
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

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.f);
        }

        public void Move(Directions dir)
        {
            switch (dir)
            {
                case Directions.LEFT:
                        x -= 1;
                    break;
                case Directions.RIGHT:
                        x += 1;
                    break;
                case Directions.DOWN:
                        y += 1;
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(" ");
        }
    }
}

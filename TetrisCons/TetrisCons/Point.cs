using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    public class Point
    {
        public int X;
        public int Y;
        public char C;

        public Point(int x, int y, char c)
        {
            this.X = x;
            this.Y = y;
            this.C = c;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            C = p.C;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.C);
            Console.SetCursorPosition(0, 0);
        }

        public void Move(Directions dir)
        {
            switch (dir)
            {
                case Directions.LEFT:
                    X -= 1;
                    break;
                case Directions.RIGHT:
                    X += 1;
                    break;
                case Directions.DOWN:
                    Y += 1;
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(" ");
        }

        public Point GetClone()
        {
            return new Point(this.X, this.Y, this.C);
        }
    }
}

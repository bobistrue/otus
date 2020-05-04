using System;

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
            DrawerProvider.Drawer.DrawPoint(X, Y);
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
                case Directions.UP:
                    Y -= 1;
                    break;
            }
        }

        internal void Hide()
        {
            DrawerProvider.Drawer.HidePoint(X, Y);
        }

        public Point GetClone()
        {
            return new Point(X, Y, C);
        }
    }
}

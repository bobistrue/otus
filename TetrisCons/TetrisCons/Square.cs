using System;

namespace TetrisCons
{
    public class Square : Figure
    {
        public Square(int x, int y, char c)
        {
            Points = new Point[4];
            Points[0] = new Point(x, y, c);
            Points[1] = new Point(x+1, y, c);
            Points[2] = new Point(x, y+1, c);
            Points[3] = new Point(x+1, y+1, c);
            Draw();
        }

        public override void Rotate(Point[] clone) { }

    }
}

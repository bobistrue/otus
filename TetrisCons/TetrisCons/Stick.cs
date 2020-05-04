using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    public class Stick : Figure
    {
        const int LENGTH = 4;
        public Stick(int x, int y, char sym)
        {
            points = new Point[4];
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y+1, sym);
            points[2] = new Point(x, y+2, sym);
            points[3] = new Point(x, y+3, sym);
            Draw();
        }

        public override void Rotate(Point[] clone)
        {
            if (clone[1].x == clone[0].x)
                RotateHorizontal(clone);
            else
                RotateVertical(clone);
        }

        private void RotateVertical(Point[] clone)
        {
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i].X = clone[0].X;
                clone[i].Y += i;
            }
        }

        private void RotateHorizontal(Point[] clone)
        {
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i].Y = clone[0].Y;
                clone[i].X += i;
            }
        }
    }
}

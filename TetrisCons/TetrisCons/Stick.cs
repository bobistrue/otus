using System;

namespace TetrisCons
{
    public class Stick : Figure
    {
        const int LENGTH = 4;
        public Stick(int x, int y, char sym)
        {
            Points = new Point[4];
            Points[0] = new Point(x, y, sym);
            Points[1] = new Point(x, y+1, sym);
            Points[2] = new Point(x, y+2, sym);
            Points[3] = new Point(x, y+3, sym);
            Draw();
        }

        public override void Rotate()
        {
            if (Points[1].X == Points[0].X)
                RotateHorizontal(Points);
            else
                RotateVertical(Points);
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

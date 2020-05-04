using System;

namespace TetrisCons
{
    public abstract class Figure
    {
        protected Point[] points;
        const int LENGTH = 4;

        protected void Draw()
        {
            foreach (Point point in points)
                point.Draw();
        }

        public void Move(Point[] pList, Directions dir)
        {
            foreach(var p in pList)
                p.Move(dir);
        }

        internal void TryMove(Directions dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if (VerifyPosition(clone))
                points = clone;
            Draw();
        }

        internal void TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);
            if (VerifyPosition(clone))
                points = clone;
            Draw();
        }

        private bool VerifyPosition(Point[] clone)
        {
            foreach (var p in clone)
                if (p.X < 0 || p.Y < 0 || p.X >= GameField.Width || p.Y >= GameField.Height) return false;
            return true;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; i++)
                newPoints[i] = points[i].GetClone();
            return newPoints;
        }

        protected void Hide()
        {
            foreach(var point in points)
                point.Hide();
        }

        public abstract void Rotate(Point[] clone);

    }
}

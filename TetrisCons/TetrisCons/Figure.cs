using System;

namespace TetrisCons
{
    public abstract class Figure
    {
        public Point[] Points;
        const int LENGTH = 4;

        protected void Draw()
        {
            foreach (Point point in Points)
                point.Draw();
        }

        public void Move(Point[] pList, Directions dir)
        {
            foreach(var p in pList)
                p.Move(dir);
        }

        internal Result TryMove(Directions dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            Result result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;
            Draw();

            return result;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);
            Result result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;
            Draw();

            return result;
        }

        private Result VerifyPosition(Point[] clone)
        {
            foreach (var p in clone)
            {
                if (p.X < 0 || p.Y < 0 || p.X >= GameField.Width)
                    return Result.BORDER_STRIKE;
                if (p.Y >= GameField.Height)
                    return Result.DOWN_BORDER_STRIKE;
                if (GameField.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCESS;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; i++)
                newPoints[i] = Points[i].GetClone();
            return newPoints;
        }

        protected void Hide()
        {
            foreach(var point in Points)
                point.Hide();
        }

        public abstract void Rotate(Point[] clone);

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }
    }
}

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

        public void Move(Directions dir)
        {
            foreach(var p in Points)
                p.Move(dir);
        }

        internal Result TryMove(Directions dir)
        {
            Hide();
            Move(dir);

            var result = VerifyPosition(Points);
            if (result != Result.SUCCESS)
                Move(Reverse(dir));

            Draw();
            return result;
        }

        private Directions Reverse(Directions dir)
        {
            switch (dir)
            {
                case Directions.LEFT:
                    return Directions.RIGHT;
                case Directions.RIGHT:
                    return Directions.LEFT;
                case Directions.DOWN:
                    return Directions.UP;
                case Directions.UP:
                    return Directions.DOWN;
            }
            return Directions.UP;
        }

        internal Result TryRotate()
        {
            Hide();
            Rotate();

            var result = VerifyPosition(Points);

            if (result != Result.SUCCESS)
                Rotate();

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

        protected void Hide()
        {
            foreach(var point in Points)
                point.Hide();
        }

        public abstract void Rotate();

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }
    }
}

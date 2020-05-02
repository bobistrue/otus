using System;

namespace TetrisCons
{
    abstract class Figure
    {
        protected Point[] coords;

        public void Draw()
        {
            foreach (Point point in coords)
                point.Draw();
        }

        public void Move(Directions dir)
        {
            switch (dir)
            {
                case Directions.Left:
                    foreach(var point in coords)
                    {
                        point.x -= 1;
                    }
                    break;
                case Directions.Right:
                    foreach (var point in coords)
                    {
                        point.x += 1;
                    }
                    break;
                case Directions.Down:
                    foreach (var point in coords)
                    {
                        point.y += 1;
                    }
                    break;
                default:
                    break;
            }
        }

        //public abstract void TurnRight();

        //public abstract void TurnLeft();
    }
}

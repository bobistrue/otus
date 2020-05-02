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

        //public abstract void Move();
        //public abstract void TurnRight();
        //public abstract void TurnLeft();
    }
}

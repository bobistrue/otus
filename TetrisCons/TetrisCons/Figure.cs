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
            foreach (Point point in coords)
                point.Move(dir);
        }

        internal void Hide()
        {
            foreach(var point in coords)
            {
                point.Hide();
            }
        }

        public abstract void Rotate(Directions dir);
    }
}

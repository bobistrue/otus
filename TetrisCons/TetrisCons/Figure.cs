using System;

namespace TetrisCons
{
    public abstract class Figure
    {
        protected Point[] coords;

        protected void Draw()
        {
            foreach (Point point in coords)
                point.Draw();
        }

        public void Move(Directions dir)
        {
            Hide();
            foreach (Point point in coords)
                point.Move(dir);
            Draw();
        }

        protected void Hide()
        {
            foreach(var point in coords)
            {
                point.Hide();
            }
        }

        public abstract void Rotate(Directions dir);
    }
}

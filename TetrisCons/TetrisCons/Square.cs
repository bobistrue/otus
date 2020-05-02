using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class Square
    {
        Point[] coords = new Point[4];

        public Square(int x, int y, char c)
        {
            coords[0] = new Point(x, y, c);
            coords[1] = new Point(x+1, y, c);
            coords[2] = new Point(x, y+1, c);
            coords[3] = new Point(x+1, y+1, c);
        }

        public void Draw()
        {
            foreach (Point point in coords) 
                point.Draw();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class Square : Figure
    {
        public Square(int x, int y, char c)
        {
            coords = new Point[4];
            coords[0] = new Point(x, y, c);
            coords[1] = new Point(x+1, y, c);
            coords[2] = new Point(x, y+1, c);
            coords[3] = new Point(x+1, y+1, c);
        }

        public override void Rotate(Directions dir) { }

    }
}

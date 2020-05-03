using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class Stick : Figure
    {
        public Stick(int x, int y, char sym)
        {
            coords = new Point[4];
            coords[0] = new Point(x, y, sym);
            coords[1] = new Point(x, y+1, sym);
            coords[2] = new Point(x, y+2, sym);
            coords[3] = new Point(x, y+3, sym);
        }

        public override void Rotate(Directions dir)
        {
            if (coords[1].x == coords[0].x)
            {
                coords[1].x += 1;
                coords[1].y -= 1;
                coords[2].x += 2;
                coords[2].y -= 2;
                coords[3].x += 3;
                coords[3].y -= 3;
            }
            else
            {
                coords[1].x -= 1;
                coords[1].y += 1;
                coords[2].x -= 2;
                coords[2].y += 2;
                coords[3].x -= 3;
                coords[3].y += 3;
            }
        }
    }
}

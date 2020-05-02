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

    }
}

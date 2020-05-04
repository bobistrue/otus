using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    class FigureGenerator
    {
        private int _x, _y;
        private char _c;
        private Random _rand = new Random();

        public FigureGenerator(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _c = sym;
        }

        public Figure GetNewFigure()
        {
            if (_rand.Next(0, 2) == 0)
                return new Stick(_x, _y, _c);
            else
                return new Square(_x, _y, _c);
        }

    }
}

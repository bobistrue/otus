using System;

namespace TetrisCons
{
    static class GameField
    {
        private static int _width = 20;
        private static int _height = 20;

        public static int Width 
        { 
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.Title = "Tetris";
                Console.SetWindowSize(Width, Height);
                Console.SetBufferSize(Width, Height);
            }
        }
        public static int Height 
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.Title = "Tetris";
                Console.SetWindowSize(Width, Height);
                Console.SetBufferSize(Width, Height);
            }
        }

        private static bool[][] _heap;
        static GameField()
        {
            _heap = new bool[Height][];
            for (int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point point)
        {
            return _heap[point.Y][point.X];
        }

        public static void AddFigure(Figure fig)
        {
            foreach (var point in fig.Points)
            {
                _heap[point.Y][point.X] = true;
            }
        }

        public static void TryDeleteLines()
        {
            int counter = 0;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (_heap[i][j]) 
                        counter++;
                }
                if (counter == Width)
                {
                    DeleteLine(i);
                    Redraw();
                }

                counter = 0;
            }
        }

        public static void DeleteLine(int rowNumber)
        {
            for (int i = rowNumber; i >= 0; i--)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0)
                        _heap[0][j] = false;
                    else
                        _heap[i][j] = _heap[i - 1][j];
                }
            }
        }

        public static void Redraw()
        {
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    if (_heap[i][j])
                        Drawer.DrawPoint(i, j);
                    else
                        Drawer.HidePoint(i, j);
        } }
    }
}

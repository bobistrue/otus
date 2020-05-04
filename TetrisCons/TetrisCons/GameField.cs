using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    static class GameField
    {
        private static int _width = 40;
        private static int _height = 30;
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

    }
}

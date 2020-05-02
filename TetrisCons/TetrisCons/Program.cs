using System;

namespace TetrisCons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tetris";
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            //Point p1 = new Point(1,2,'+');
            //p1.Draw();

            //Point p2 = new Point(2, 4, '-');
            //p2.Draw();

            //Point p3 = new Point() { x = 1, y = 4, f = '*' };
            //p3.Draw();

            Square sq1 = new Square(1, 1, '.');
            sq1.Draw();

            Stick st1 = new Stick(4, 1, '+');
            st1.Draw();

            Console.ReadLine();
        }

        
    }
}

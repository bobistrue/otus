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

            Figure[] figs = new Figure[2];
            figs[0] = new Square(1, 1, 'x');
            figs[1] = new Stick(4, 1, 'o');

            foreach (var fig in figs) fig.Draw();


            Console.ReadLine();
        }

        
    }
}

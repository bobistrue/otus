using System;
using System.Threading;

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

            foreach (var fig in figs)
            {
                fig.Draw();

                Thread.Sleep(1000); 
                fig.Hide();
                fig.Move(Directions.RIGHT);
                fig.Draw();
            }


            Console.ReadLine();
        }

        
    }
}

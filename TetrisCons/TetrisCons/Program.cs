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

            FigureGenerator generator = new FigureGenerator(5, 5, 'o');

            Figure currentFigure = generator.GetNewFigure();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    HandleKey(currentFigure, key);
                }
            }

            Console.ReadLine();
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Directions.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Directions.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Directions.DOWN);
                    break;
                case ConsoleKey.Spacebar:
                    currentFigure.TryRotate();
                    break;
            }
        }

        //static void FigureFall(out Figure fig, FigureGenerator generator)
        //{
        //    fig = generator.GetNewFigure();
        //    fig.Draw();

        //    for (int i = 0; i < 15; i++)
        //    {
        //    }
        //}

        
    }
}

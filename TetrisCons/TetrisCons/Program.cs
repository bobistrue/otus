using System;
using System.Threading;
using System.Timers;

namespace TetrisCons
{
    class Program
    {
        static FigureGenerator generator;
        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {
            Console.Title = "Tetris";
            Console.SetWindowSize(GameField.Width, GameField.Height);
            Console.SetBufferSize(GameField.Width, GameField.Height);

            generator = new FigureGenerator(GameField.Width / 2, 0, Drawer.DEFAULT_SYMBOL);
            Figure currentFigure = generator.GetNewFigure();

            SetTimer();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    var result = HandleKey(currentFigure, key);
                    ProcessResult(result, ref currentFigure);
                }
            }
        }

        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {
                GameField.AddFigure(currentFigure);
                GameField.TryDeleteLines();
                currentFigure = generator.GetNewFigure();
                return true;
            }
            return false;
        }

        private static Result HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    return currentFigure.TryMove(Directions.LEFT);
                case ConsoleKey.RightArrow:
                    return currentFigure.TryMove(Directions.RIGHT);
                case ConsoleKey.DownArrow:
                    return currentFigure.TryMove(Directions.DOWN);
                case ConsoleKey.Spacebar:
                    return currentFigure.TryRotate();
            }
            return Result.SUCCESS;
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

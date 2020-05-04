using System;
using System.Threading;
using System.Timers;

namespace TetrisCons
{
    class Program
    {
        static int TIMER_INTERVAL = 500;
        static System.Timers.Timer aTimer;
        static Object _lockObject = new object();

        static Figure currentFigure;
        static FigureGenerator generator;

        static void Main(string[] args)
        {
            Console.Title = "Tetris";
            Console.SetWindowSize(GameField.Width, GameField.Height);
            Console.SetBufferSize(GameField.Width, GameField.Height);

            generator = new FigureGenerator(GameField.Width / 2, 0, Drawer.DEFAULT_SYMBOL);
            currentFigure = generator.GetNewFigure();

            SetTimer();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    Monitor.Enter(_lockObject);
                    var result = HandleKey(currentFigure, key);
                    ProcessResult(result, ref currentFigure);
                    Monitor.Exit(_lockObject);
                }
            }
        }

        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(TIMER_INTERVAL);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Monitor.Enter(_lockObject);
            var result = currentFigure.TryMove(Directions.DOWN);
            ProcessResult(result, ref currentFigure);
            Monitor.Exit(_lockObject);
        }

        private static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {
                GameField.AddFigure(currentFigure);
                GameField.TryDeleteLines();
                if (currentFigure.IsOnTop())
                {
                    WriteGameOver();
                    aTimer.Elapsed -= OnTimedEvent;
                    return true;
                }
                else
                {
                    currentFigure = generator.GetNewFigure();
                    return false;
                }
            }
            else
                return false;
        }

        private static void WriteGameOver()
        {
            Console.SetCursorPosition(GameField.Width / 2 - 8, GameField.Height / 2 - 2);
            Console.WriteLine("G A M E   O V E R");
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
        
    }
}

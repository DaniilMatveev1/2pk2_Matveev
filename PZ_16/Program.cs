using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeGame
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ИГРА ЗМЕЙКА");
                Console.WriteLine("НАЧАТЬ ИГРУ (НАЖАТЬ 1)");
                Console.WriteLine("ВЫЙТИ (НАЖАТЬ 2)");

                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    SnakeGame game = new SnakeGame();
                    game.Run();
                }
                else if (choice == "2")
                {
                    break;
                }
            }
        }

        class SnakeGame
        {
            private const int width = 50;
            private const int height = 25;
            private const char snakeSymbol = '■';
            private const char foodSymbol = '■';
            private const char obstacleSymbol = '▒';
            private const char bombSymbol = 'X';

            private List<Point> snake;
            private Point food;
            private List<Point> obstacles;
            private List<Point> bombs;
            private Random random;
            private Direction direction;
            private bool gameOver;

            private int score;
            private int bombCount;
            private int obstacleCount;

            public SnakeGame()
            {
                snake = new List<Point>();
                random = new Random();
                direction = Direction.Right;
                gameOver = false;
                score = 0;
                bombCount = 15;
                obstacleCount = 10;
            }

            public void Run()
            {
                Console.CursorVisible = false;
                Console.SetWindowSize(width + 1, height + 1);
                Console.SetBufferSize(width + 1, height + 1);

                InitializeSnake();
                GenerateFood();
                GenerateObstacles();
                GenerateBombs();

                while (!gameOver)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(intercept: true).Key;

                        switch (key)
                        {
                            case ConsoleKey.UpArrow:
                                if (direction != Direction.Down)
                                    direction = Direction.Up;
                                break;
                            case ConsoleKey.DownArrow:
                                if (direction != Direction.Up)
                                    direction = Direction.Down;
                                break;
                            case ConsoleKey.LeftArrow:
                                if (direction != Direction.Right)
                                    direction = Direction.Left;
                                break;
                            case ConsoleKey.RightArrow:
                                if (direction != Direction.Left)
                                    direction = Direction.Right;
                                break;
                            case ConsoleKey.Escape:
                                return;
                        }
                    }

                    Move();

                    if (gameOver)
                        break;

                    Thread.Sleep(150);
                }

                ShowGameOverScreen();
                Console.ReadKey();
            }

            private void InitializeSnake()
            {
                // Располагаем змейку в середине поля
                int centerX = width / 2;
                int centerY = height / 2;

                for (int i = 0; i < 4; i++)
                {
                    snake.Add(new Point(centerX - i, centerY));
                }
                
                foreach (var point in snake)
                {
                    DrawPoint(point, snakeSymbol);
                }
            }

            private void GenerateFood()
            {
                food = GenerateRandomPoint();
                DrawPoint(food, foodSymbol);
            }

            private void GenerateBombs()
            {
                bombs = new List<Point>();

                for (int i = 0; i < bombCount; i++)
                {
                    Point bomb = GenerateRandomPoint();
                    bombs.Add(bomb);
                    DrawPoint(bomb, bombSymbol);
                }
            }

            private void GenerateObstacles()
            {
                obstacles = new List<Point>();

                for (int i = 0; i < obstacleCount; i++)
                {
                    Point obstacle = GenerateRandomPoint();
                    obstacles.Add(obstacle);
                    DrawPoint(obstacle, obstacleSymbol);
                }
            }

            private Point GenerateRandomPoint()
            {
                int x = random.Next(1, width - 1);
                int y = random.Next(1, height - 1);
                return new Point(x, y);
            }

            private void Move()
            {
                var head = snake.First();
                var newHead = new Point(head.X, head.Y);

                switch (direction)
                {
                    case Direction.Up:
                        newHead.Y--;
                        break;
                    case Direction.Down:
                        newHead.Y++;
                        break;
                    case Direction.Left:
                        newHead.X--;
                        break;
                    case Direction.Right:
                        newHead.X++;
                        break;
                }

                if (newHead.X <= 0 || newHead.X >= width ||
                    newHead.Y <= 0 || newHead.Y >= height ||
                    snake.Any(segment => segment.X == newHead.X && segment.Y == newHead.Y) ||
                    obstacles.Any(obstacle => obstacle.X == newHead.X && obstacle.Y == newHead.Y))
                {
                    gameOver = true;
                    return;
                }

                snake.Insert(0, newHead);
                DrawPoint(newHead, snakeSymbol);

                if (newHead.X == food.X && newHead.Y == food.Y)
                {
                    // Змейка съела еду
                    score += 5;
                    GenerateFood();
                }
                else
                {
                    // Удаляем конец змейки
                    var tail = snake.Last();
                    DrawPoint(tail, ' ');
                    snake.Remove(tail);
                }

                if (bombs.Any(bomb => bomb.X == newHead.X && bomb.Y == newHead.Y))
                {
                    // Змейка задела бомбу и уменьшилась
                    score -= 20;

                    if (snake.Count > 2)
                    {
                        var tail = snake.Last();
                        DrawPoint(tail, ' ');
                        snake.Remove(tail);
                    }
                }

                if (score < 0)
                    score = 0;

                DrawScore();
            }

            private void DrawPoint(Point point, char symbol)
            {
                Console.SetCursorPosition(point.X, point.Y);
                Console.Write(symbol);
            }

            private void DrawScore()
            {
                Console.SetCursorPosition(0, height);
                Console.Write("СЧЕТ: " + score);
            }

            private void ShowGameOverScreen()
            {
                int centerX = width / 2 - 6;
                int centerY = height / 2;

                Console.Clear();
                Console.SetCursorPosition(centerX, centerY);
                Console.WriteLine("ИГРА ОКОНЧЕНА!");
                Console.SetCursorPosition(centerX - -3, centerY + 1);
                Console.WriteLine("СЧЕТ: " + score);
                Console.SetCursorPosition(centerX - 11, centerY + 2);
                Console.WriteLine("НАЖАТЬ НА ЛЮБУЮ КЛАВИШУ ДЛЯ РЕСТАРТА");
            }
        }
    }
}
    

   
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int width = 40;
    static int height = 20;
    static int score = 0;
    static Random rand = new Random();

    static (int x, int y) food;
    static (int x, int y) direction = (1, 0);

    static List<(int x, int y)> snake = new List<(int x, int y)>
    {
        (10, 10),
        (9, 10),
        (8, 10)
    };

    static void Main()
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(width + 2, height + 3);
        Console.SetBufferSize(width + 2, height + 3);

        SpawnFood();

        Thread inputThread = new Thread(ReadInput);
        inputThread.Start();

        while (true)
        {
            Move();
            Draw();
            Thread.Sleep(100);
        }
    }

    static void ReadInput()
    {
        while (true)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (direction != (0, 1)) direction = (0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != (0, -1)) direction = (0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction != (1, 0)) direction = (-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != (-1, 0)) direction = (1, 0);
                    break;
            }
        }
    }


    static void Move()
    {
        var head = snake[0];
        var newHead = (head.Item1 + direction.Item1, head.Item2 + direction.Item2);

        if (newHead.Item1 < 0 || newHead.Item1 >= width || newHead.Item2 < 0 || newHead.Item2 >= height)
            GameOver();

        if (snake.Contains(newHead))
            GameOver();

        snake.Insert(0, newHead);

        if (newHead == food)
        {
            score++;
            SpawnFood();
        }
        else
        {
            snake.RemoveAt(snake.Count - 1);
        }
    }

    static void SpawnFood()
    {
        do
        {
            food = (rand.Next(0, width), rand.Next(0, height));
        }
        while (snake.Contains(food));
    }

    static void Draw()
    {
        Console.Clear();

        for (int x = 0; x <= width + 1; x++)
        {
            Console.SetCursorPosition(x, 0);
            Console.Write("#");
            Console.SetCursorPosition(x, height + 1);
            Console.Write("#");
        }

        for (int y = 0; y <= height + 1; y++)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("#");
            Console.SetCursorPosition(width + 1, y);
            Console.Write("#");
        }

        foreach (var part in snake)
        {
            Console.SetCursorPosition(part.Item1 + 1, part.Item2 + 1);
            Console.Write("O");
        }

        Console.SetCursorPosition(food.Item1 + 1, food.Item2 + 1);
        Console.Write("@");


        Console.SetCursorPosition(0, height + 2);
        Console.Write($"Score: {score}");
    }

    static void GameOver()
    {
        Console.Clear();
        Console.SetCursorPosition(width / 2 - 5, height / 2);
        Console.WriteLine("GAME OVER!");
        Console.SetCursorPosition(width / 2 - 6, height / 2 + 1);
        Console.WriteLine($"Your Score: {score}");
        Console.SetCursorPosition(width / 2 - 10, height / 2 + 2);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

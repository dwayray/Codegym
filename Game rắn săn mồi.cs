using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int width = 20;
    static int height = 10;
    static int score = 0;
    static Random rand = new Random();

    static (int, int) food;
    static (int, int) direction = (1, 0);

    static List<(int, int)> snake = new List<(int, int)>
    {
        (5, 5),
        (4, 5),
        (3, 5)
    };

    static void Main()
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(width + 2, height + 3);
        Console.SetBufferSize(width + 2, height + 3);

        ShowInstructions();
        SpawnFood();

        Thread inputThread = new Thread(ReadInput);
        inputThread.Start();

        while (true)
        {
            Move();
            Draw();
            Thread.Sleep(200);
        }
    }

    static void ShowInstructions()
    {
        Console.Clear();
        Console.WriteLine("=== Snake Game ===");
        Console.WriteLine("Nhan phim bat ki de bat dau");
        Console.ReadKey(true);
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
        Console.SetCursorPosition(0, 0);

        // Vien
        Console.WriteLine(new string('#', width + 2));

        for (int y = 0; y < height; y++)
        {
            Console.Write("#");
            for (int x = 0; x < width; x++)
            {
                if (snake[0] == (x, y))
                    Console.Write("O"); // dau ran
                else if (snake.Contains((x, y)))
                    Console.Write("o"); // than ran
                else if (food == (x, y))
                    Console.Write("@");
                else
                    Console.Write(" ");
            }
            Console.WriteLine("#");
        }

        // Vien duoi
        Console.WriteLine(new string('#', width + 2));

        Console.WriteLine($"Điểm: {score}");
    }

    static void GameOver()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(" GAME OVER!");
        Console.WriteLine($" Diem cua ban: {score}");
        Console.WriteLine("Nhan phim bat ki de thoat...");
        Console.ReadKey(true);
        Environment.Exit(0);
    }
}

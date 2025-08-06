public class Board
{
    private char[,] grid;

    public Board()
    {
        grid = new char[3, 3];
        Reset();
    }

    public void Reset()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                grid[i, j] = ' ';
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("  0   1   2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {grid[i, j]} ");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine(" ---+---+---");
        }
    }

    public bool PlaceMove(int row, int col, char symbol)
    {
        if (row < 0 || row >= 3 || col < 0 || col >= 3 || grid[row, col] != ' ')
            return false;

        grid[row, col] = symbol;
        return true;
    }

    public bool CheckWin(char symbol)
    {
        // Hàng, cột và đường chéo
        for (int i = 0; i < 3; i++)
            if ((grid[i, 0] == symbol && grid[i, 1] == symbol && grid[i, 2] == symbol) ||
                (grid[0, i] == symbol && grid[1, i] == symbol && grid[2, i] == symbol))
                return true;

        return (grid[0, 0] == symbol && grid[1, 1] == symbol && grid[2, 2] == symbol) ||
               (grid[0, 2] == symbol && grid[1, 1] == symbol && grid[2, 0] == symbol);
    }

    public bool IsFull()
    {
        foreach (var cell in grid)
            if (cell == ' ')
                return false;
        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Game Co Caro 3x3 (Tic Tac Toe)");
        Console.WriteLine("1. Nguoi va May");
        Console.WriteLine("2. solo");
        Console.Write("Chon che do choi (1 or 2): ");

        int mode;
        while (!int.TryParse(Console.ReadLine(), out mode) || (mode != 1 && mode != 2))
        {
            Console.Write("Nhap 1 or 2 ");
        }

        IPlayer player1 = new HumanPlayer("Nguoi choi 1", 'X');
        IPlayer player2;

        if (mode == 1)
            player2 = new ComputerPlayer("May", 'O');
        else
            player2 = new HumanPlayer("Nguoi choi 2", 'O');

        Game game = new Game(player1, player2);

        while (true)
        {
            game.Play();

            Console.Write("Choi tiep? (y/n): ");
            string? again = Console.ReadLine();
            if (again == null || again.ToLower() != "y") break;
            if (again != "y") break;
        }

        Console.WriteLine("Thank");
    }
}


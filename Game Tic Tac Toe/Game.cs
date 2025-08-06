public class Game
{
    private Board board;
    private IPlayer player1;
    private IPlayer player2;
    private GameStats stats;

    public Game(IPlayer p1, IPlayer p2)
    {
        board = new Board();
        player1 = p1;
        player2 = p2;
        stats = GameStats.Load();
    }

    public void Play()
    {
        bool gameEnded = false;
        board.Reset();

        IPlayer current = player1;
        board.Display();

        while (!gameEnded)
        {
            current.MakeMove(board);
            board.Display();

            if (board.CheckWin(current.Symbol))
            {
                Console.WriteLine($"{current.Name} Win!");
                if (current == player1) stats.Player1Wins++;
                else stats.Player2Wins++;
                gameEnded = true;
            }
            else if (board.IsFull())
            {
                Console.WriteLine("Hoa!");
                stats.Draws++;
                gameEnded = true;
            }
            else
            {
                current = (current == player1) ? player2 : player1;
            }
        }

        stats.GamesPlayed++;
        stats.Save();
        Console.WriteLine(stats);
    }
}

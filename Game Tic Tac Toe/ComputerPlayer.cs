public class ComputerPlayer : Player
{
    private Random rand = new Random();

    public ComputerPlayer(string name, char symbol) : base(name, symbol) { }

    public override void MakeMove(Board board)
    {
        Console.WriteLine($"{Name} ({Symbol}) Dang  danh..");

        int row, col;
        do
        {
            row = rand.Next(0, 3);
            col = rand.Next(0, 3);
        } while (!board.PlaceMove(row, col, Symbol));
    }
}

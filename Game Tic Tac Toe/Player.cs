public abstract class Player : IPlayer
{
    public string Name { get; protected set; }
    public char Symbol { get; protected set; }

    public Player(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    public abstract void MakeMove(Board board);
}

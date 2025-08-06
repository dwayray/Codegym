public interface IPlayer
{
    char Symbol { get; }
    string Name { get; }
    void MakeMove(Board board);
}

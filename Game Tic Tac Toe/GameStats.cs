 using System.Text.Json;
public class GameStats
{
    public int GamesPlayed { get; set; } = 0;
    public int Player1Wins { get; set; } = 0;
    public int Player2Wins { get; set; } = 0;
    public int Draws { get; set; } = 0;

    private static string path = "gamestats.json";

    public void Save()
    {
        var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }

    public static GameStats Load()
    {
        if (!File.Exists(path)) return new GameStats();

        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<GameStats>(json) ?? new GameStats();
    }

    public override string ToString()
    {
        return $"So  lan choi: {GamesPlayed}, Win: P1={Player1Wins}, P2={Player2Wins}, Hoa: {Draws}";
    }
}

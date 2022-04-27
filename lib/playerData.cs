namespace lib;

public class PlayerData : ChessGame, IaddGames
{
    public static int TotalUserCount = Players.PlayerBase.Count;
    public int PlayerCode { get; set; }
    public string UserName { get; set; }
    public int GameCount { get; set; } = 0;
    public List<List<string>> Games { get; set; } = new List<List<string>>();
    public List<string> CurrentGame { get; set; } = new List<string>();
    public override string GetGameAt(int i)
    {
        List<string> gotGame = Games[i];
        return string.Join(" ", gotGame);
    }
    public PlayerData(string thing)
    {
        if (thing != null && thing.Length > 2)
        {
            UserName = thing;
            PlayerCode = TotalUserCount;
            TotalUserCount++;
        }
    }
    public PlayerData() { }
    public void addMove(string f)
    {
        CurrentGame.Add(f);
    }
    public void addGame()
    {
        Games.Add(CurrentGame);
        GameCount++;
        CurrentGame = new List<string>();
    }
    public void WholeGame(string f)
    {
        string[] wholeGame = f.Split(' ');
        for (int i = 0; i < wholeGame.Length; i++)
        {
            CurrentGame.Add(wholeGame[i]);
        }
        addGame();
    }

}
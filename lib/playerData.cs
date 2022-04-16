namespace lib;

public class playerData : ChessGame, IaddGames
{
    public static int totalUserCount;
    public int playerCode;
    public string userName;
    public int gamecount = 0;
    public string displayedGame;
    public static string y;
    public List<List<string>> games = new List<List<string>>();
    public List<string> currentgame = new List<string>();
    public override string getGameAt(int i)
    {
        List<string> gotGame = games[i];
        return string.Join(" ", gotGame);
    }
    public playerData(string thing)
    {
        if (thing != null && thing.Length > 2)
        {
            userName = thing;
            playerCode = totalUserCount;
            totalUserCount++;
        }
    }
    public void addMove(string f)
    {
        currentgame.Add(f);
    }
    public void addGame()
    {
        games.Add(currentgame);
        gamecount++;
    }
    public void WholeGame(string f)
    {
        string[] wholeGame = f.Split(' ');
        for (int i = 0; i < wholeGame.Length; i++)
        {
            currentgame.Add(wholeGame[i]);
        }
        addGame();
    }

}

namespace lib;

public class playerData : ChessGame, IaddGames
{
    public static int totalUserCount;
    public int playerCode;
    public string userName;
    public int gamecount = 0;
    public List<List<string>> games = new List<List<string>>();
    public List<string> currentGame = new List<string>();
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
        currentGame.Add(f);
    }
    public void addGame()
    {
        games.Add(currentGame);
        gamecount++;
        currentGame.Clear();
    }
    public void WholeGame(string f)
    {
        string[] wholeGame = f.Split(' ');
        for (int i = 0; i < wholeGame.Length; i++)
        {
            currentGame.Add(wholeGame[i]);
        }
        addGame();
    }

}
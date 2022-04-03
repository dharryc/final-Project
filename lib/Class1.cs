namespace lib;

public static class players
{
    public static int thing = 0;
    public static string errorTime;
    public static List<playerData> playerBase = new List<playerData>();
    public static void Add(playerData player, string userName)
    {
        if (userName.Length > 2)
        {
            playerBase.Add(player);
            errorTime = null;
            thing = 1;
        }
        else
        {
            errorTime = "That name is too short";
        }
    }

}
public interface IaddGames
{
    public void findGame(int game, playerData player)
    {
        player.getGameAt(game);
    }
}
public abstract class ChessGame
{
    public abstract string getGameAt(int i);
}
public class playerData : ChessGame, IaddGames
{
    public string errorCode;
    public string userName;
    public int gamecount = 0;
    public int movecount = 0;
    public string displayedGame;
    public List<string[]> games = new List<string[]>();
    public string[] currentgame = new string[3];
    public override string getGameAt(int i)
    {
        return string.Join(" ", games[i]);
    }
    public playerData(string thing)
    {
        if (thing != null && thing.Length > 3)
        {
            userName = thing;
        }
    }
    public void addMove(string y)
    {
        currentgame[movecount] = y;
        movecount ++;
    }
    public void addGame()
    {
        games.Add(currentgame);
        currentgame = null;
        movecount = 0;
    }
    public void wholeGame(string y)
    {
        currentgame = y.Split(' ');
        games.Add(currentgame);
    }

}
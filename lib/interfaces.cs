namespace lib;
public interface IaddGames
{
    public void FindGame(int game, PlayerData player)
    {
        player.GetGameAt(game);
    }
}
public abstract class ChessGame
{
    public abstract string GetGameAt(int i);
}
public interface IStorageService
{
    List<PlayerData> Load();
    void Save(List<PlayerData> users);
}
namespace lib;

public static class players
{
    public static string errorTime;
    public static bool displayPlayers = false;
    public static List<playerData> playerBase = new List<playerData>();
    public static void Add(playerData player, string userName)
    {
        if (userName.Length >= 2)
        {
            playerBase.Add(player);
            errorTime = null;
        }
        else
        {
            errorTime = "That name is too short";
        }
    }

}

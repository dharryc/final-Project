namespace lib;
using System;

public static class storage
{
    public static void store()
    {
        using StreamWriter file = new("playerbase.txt");
        foreach (playerData user in players.playerBase)
        {
            file.WriteLine(user.userName);
        }
    }
}
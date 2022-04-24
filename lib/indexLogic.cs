namespace lib;
public static class indexLogic
{
    public static string userName;
    public static bool check = false;
    public static bool RepeatUser = true;

    public static void doAdd()
    {
        players.errorTime = "";
        RepeatUser = false;
        multiple();
        if (userName != null)
        {
            if (!RepeatUser)
            {
                if (userName.Length > 2)
                {
                    players.Add(new playerData(userName), userName);
                    players.errorTime = $"Username successfully entered!";
                    players.NewPlayer = true;
                    userName = "";
                }
                else
                {
                    players.errorTime = "That name is too short";
                    userName = "";
                }
            }
            else
            {
                players.errorTime = "That username is already taken";
                userName = "";
            }
        }
        else
        {
            players.errorTime = "Oi! Don't give me a null value! That's mean";
        }
    }
    public static void multiple()
    {
        for (int i = 0; i < playerData.totalUserCount; i++)
        {
            for (int j = 0; i < playerData.totalUserCount; i++)
            {
                if (players.playerBase[j].userName == players.playerBase[i].userName)
                {
                    RepeatUser = true;
                }
            }
        }
    }
    public static void Confirm()
    {
        check = true;
    }
    public static void cancel()
    {
        check = false;
    }
    public static void deleteJson()
    {
        players.DeleteJson();
        check = false;
        players.NewPlayer = false;
        players.errorTime = "";
    }
    public static void clear()
    {
        players.errorTime = "";
    }
}
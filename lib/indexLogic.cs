namespace lib;
public static class indexLogic
{
    public static string UserName;
    public static bool ConfirmDelete = false;
    public static bool RepeatUser = true;

    public static void doAdd()
    {
        Players.ErrorMessage = "";
        RepeatUser = false;
        multiple();
        if (UserName != null)
        {
            if (!RepeatUser)
            {
                if(!UserName.Contains(" "))
                {
                    if (UserName.Length > 2)
                    {
                        Players.Add(new PlayerData(UserName), UserName);
                        Players.ErrorMessage = "Username successfully entered!";
                        Players.NewPlayer = true;
                        UserName = "";
                        Players.SavePlayers();
                        if (Players.PlayerBase.Count > 0)
                        {
                            Players.DisplayPlayers = true;
                        }
                    }
                    else
                    {
                        Players.ErrorMessage = "That name is too short";
                        UserName = "";
                    }
                }
                else
                {
                    Players.ErrorMessage = "Please enter a username with no spaces.";
                    UserName = "";
                }
            }
            else
            {
                Players.ErrorMessage = "That username is already taken";
                UserName = "";
            }
        }
        else
        {
            Players.ErrorMessage = "Oi! Don't give me a null value! That's mean";
        }
    }
    public static void multiple()
    {
        for (int i = 0; i < PlayerData.TotalUserCount; i++)
        {
            if (UserName == Players.PlayerBase[i].UserName)
            {
                RepeatUser = true;
            }
        }
    }
    public static void Confirm()
    {
        ConfirmDelete = true;
    }
    public static void cancel()
    {
        ConfirmDelete = false;
    }
    public static void deleteJson()
    {
        Players.DeleteJson();
        ConfirmDelete = false;
        Players.NewPlayer = false;
        Players.ErrorMessage = "";
    }
    public static void clear()
    {
        Players.ErrorMessage = "";
    }
}
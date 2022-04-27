namespace lib;
public static class UserPageNavigation
{
    public static string UserInput;
    public static bool ShowNavButtons = false;
    public static string ErrorMessage = null;
    public static bool GameShow = false;
    public static bool ShowSingleUser = false;
    public static bool AddGameMoveByMove = false;
    public static int SelectedPlayer;
    public static bool AddEntireGame = false;
    public static bool AddCurrentGame = false;
    public static void select()
    {
        try
        {
            SelectedPlayer = Int32.Parse(UserInput);
            if (SelectedPlayer <= PlayerData.TotalUserCount)
            {
                ErrorMessage = null;
                ShowSingleUser = true;
                ShowNavButtons = true;
                AddGameMoveByMove = false;
                GameShow = false;
                AddEntireGame = false;
            }
            else
            {
                ErrorMessage = "That number is too big dude";
                UserInput = "";
            }
        }
        catch
        {
            emptyErrorCode();
        }
    }
    public static void show()
    {
        GameShow = true;
        ShowNavButtons = false;
        ErrorMessage = "";
    }
    public static void hide()
    {
        ErrorMessage = "";
        ShowSingleUser = false;
        UserInput = "";
    }
    public static void singleMove()
    {
        UserInput = "";
        AddGameMoveByMove = true;
        GameShow = false;
        AddEntireGame = false;
        ShowNavButtons = false;
        ErrorMessage = "";
    }
    public static void entireMove()
    {
        UserInput = "";
        AddEntireGame = true;
        GameShow = false;
        AddGameMoveByMove = false;
        ShowNavButtons = false;
        ErrorMessage = "";
    }
    public static void backToSingleUser()
    {
        UserInput = "";
        ShowNavButtons = true;
        AddGameMoveByMove = false;
        GameShow = false;
        AddEntireGame = false;
        ErrorMessage = "";
    }
    public static void noNewGame()
    {
        AddCurrentGame = false;
        Players.SavePlayers();
    }
    public static void oneMove()
    {
        if (UserInput != "" && UserInput != null)
        {
            foreach (PlayerData user in Players.PlayerBase)
            {
                if (user.PlayerCode == SelectedPlayer)
                {
                    user.addMove(UserInput);
                }
            }
            UserInput = "";
            ErrorMessage = "Move successfully entered";
        }
        else
        {
            emptyErrorCode();
        }
    }
    public static void appendGame()
    {
        foreach (PlayerData user in Players.PlayerBase)
        {
            if (user.PlayerCode == SelectedPlayer)
            {
                user.addGame();
            }
        }
        ErrorMessage = "Game successfully entered";
        AddCurrentGame = true;
    }
    public static void appendWholeGame()
    {
        if (UserInput != "" && UserInput != null)
        {
            foreach (PlayerData user in Players.PlayerBase)
            {
                if (user.PlayerCode == SelectedPlayer)
                {
                    user.WholeGame(UserInput);
                    UserInput = "";
                    ErrorMessage = "Game successfully entered";
                }
            }
            AddCurrentGame = true;
        }
        else
        {
            emptyErrorCode();
        }
    }
    static void emptyErrorCode()
    {
        Random generator = new();
        int i = generator.Next(0, 4);
        switch (i)
        {
            case 0: ErrorMessage = "I really don't like it when you give me empty values"; break;
            case 1: ErrorMessage = "Oi, bro, thats empty"; break;
            case 2: ErrorMessage = "Nah man, that's still empty"; break;
            case 3: ErrorMessage = "Bro, I set up a whole random number generator for this. This is a pain. Don't give me empty values"; break;
        }
    }
}
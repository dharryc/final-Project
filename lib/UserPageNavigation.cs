namespace lib;
public static class UserPageNavigation
{
    public static string thing;
    public static bool options = false;
    public static string error = null;
    public static bool gameShow = false;
    public static bool singleUser = false;
    public static bool moveByMove = false;
    public static int playerSelection;
    public static bool entireGame = false;
    public static bool gameadd = false;
    public static string game;
    public static void select()
    {
        try
        {
            playerSelection = Int32.Parse(thing);
            if (playerSelection <= playerData.totalUserCount)
            {
                error = null;
                singleUser = true;
                options = true;
                moveByMove = false;
                gameShow = false;
                entireGame = false;
            }
            else
            {
                error = "That number is too big dude";
                thing = "";
            }
        }
        catch
        {
            emptyErrorCode();
        }
    }
    public static void show()
    {
        gameShow = true;
        options = false;
        error = "";
    }
    public static void hide()
    {
        error = "";
        singleUser = false;
        thing = "";
    }
    public static void singleMove()
    {
        thing = "";
        moveByMove = true;
        gameShow = false;
        entireGame = false;
        options = false;
        error = "";
    }
    public static void entireMove()
    {
        thing = "";
        entireGame = true;
        gameShow = false;
        moveByMove = false;
        options = false;
        error = "";
    }
    public static void backToSingleUser()
    {
        thing = "";
        options = true;
        moveByMove = false;
        gameShow = false;
        entireGame = false;
        error = "";
    }
    public static void noNewGame()
    {
        gameadd = false;
        players.SavePlayers();
    }
    public static void oneMove()
    {
        if (thing != "" && thing != null)
        {
            foreach (playerData user in players.playerBase)
            {
                if (user.playerCode == playerSelection)
                {
                    user.addMove(thing);
                }
            }
            thing = "";
            error = "Move successfully entered";
        }
        else
        {
            emptyErrorCode();
        }
    }
    public static void appendGame()
    {
        foreach (playerData user in players.playerBase)
        {
            if (user.playerCode == playerSelection)
            {
                user.addGame();
            }
        }
        error = "Game successfully entered";
        gameadd = true;
    }
    public static void appendWholeGame()
    {
        if (thing != "" && thing != null)
        {
            foreach (playerData user in players.playerBase)
            {
                if (user.playerCode == playerSelection)
                {
                    user.WholeGame(thing);
                    thing = "";
                    error = "Game successfully entered";
                }
            }
            gameadd = true;
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
            case 0: error = "I really don't like it when you give me empty values"; break;
            case 1: error = "Oi, bro, thats empty"; break;
            case 2: error = "Nah man, that's still empty"; break;
            case 3: error = "Bro, I set up a whole random number generator for this. This is a pain. Don't give me empty values"; break;
        }
    }
}
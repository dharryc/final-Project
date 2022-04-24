namespace lib;

public static class players
{
    private static IStorageService StorageService;
    public static bool NewPlayer = false;
    public static string errorTime;
    public static bool displayPlayers = false;
    public static List<playerData> playerBase { get; set; } = new List<playerData>();
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
    public static void SetStorageService(IStorageService storageService)
    {
        StorageService = storageService;
    }
    public static void SavePlayers()
    {
        StorageService.Save(playerBase);
        NewPlayer = false;
    }
    public static void RecoverPlayers()
    {
        playerBase = StorageService.Load();
    }
    public static void DeleteJson()
    {
        if(File.Exists("playerbase.json"))
        {
            File.Delete("playerbase.json");
        }
        playerBase = new List<playerData>();
        displayPlayers = false;
        playerData.totalUserCount = 0;
    }
}
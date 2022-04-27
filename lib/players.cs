namespace lib;

public static class Players
{
    private static IStorageService StorageService;
    public static bool NewPlayer = false;
    public static string ErrorMessage;
    public static bool DisplayPlayers = false;
    public static List<PlayerData> PlayerBase { get; set; } = new List<PlayerData>();
    public static void Add(PlayerData player, string userName)
    {
        if (userName.Length >= 2)
        {
            PlayerBase.Add(player);
            ErrorMessage = null;
        }
        else
        {
            ErrorMessage = "That name is too short";
        }
    }
    public static void SetStorageService(IStorageService storageService)
    {
        StorageService = storageService;
    }
    public static void SavePlayers()
    {
        StorageService.Save(PlayerBase);
        NewPlayer = false;
    }
    public static void RecoverPlayers()
    {
        PlayerBase = StorageService.Load();
    }
    public static void DeleteJson()
    {
        if(File.Exists("playerbase.json"))
        {
            File.Delete("playerbase.json");
        }
        PlayerBase = new List<PlayerData>();
        DisplayPlayers = false;
        PlayerData.TotalUserCount = 0;
    }
}
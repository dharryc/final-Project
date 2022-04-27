namespace lib;
using System.Text.Json;
public class Storage : IStorageService
{

    public List<PlayerData> Load()
    {
        List<PlayerData>? list = JsonSerializer.Deserialize<List<PlayerData>>(File.ReadAllText("playerbase.json"));
        return list;
    }

    public void Save(List<PlayerData> users)
    {
        string playerBasejson = JsonSerializer.Serialize(users);
        File.WriteAllText("playerbase.json", playerBasejson);
    }
}
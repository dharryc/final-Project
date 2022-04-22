namespace lib;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public interface IStorageService
{
    List<playerData> Load();
    void Save(List<playerData> users);
}
public class storage : IStorageService
{

    public List<playerData> Load()
    {
        List<playerData>? list = JsonSerializer.Deserialize<List<playerData>>(File.ReadAllText("playerbase.json"));
        return list;
    }

    public void Save(List<playerData> users)
    {
        string playerBasejson = JsonSerializer.Serialize(users);
        File.WriteAllText("playerbase.json", playerBasejson);
    }
}
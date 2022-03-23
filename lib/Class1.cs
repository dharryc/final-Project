namespace lib;
public class playerlist
{
    public List<playerData> playerBase = new List<playerData>();
}
public class playerData
{
    public string thing = "no";
    public void rename()
    {
        Random generator = new Random();
        int yep = generator.Next(0,13);
        if(yep == 0)
            thing = "Heyo";
        else if(yep == 1)
            thing = "Why tho";
        else if(yep == 5)
            thing = "Yee";
        else if(yep == 12)
            thing = "Nah bro";
        else
            thing = "Oh no, it didn't choose one of the nice ones";
    }
}

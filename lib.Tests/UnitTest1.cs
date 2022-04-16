using NUnit.Framework;

namespace lib.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddSingleMoveGame()
    {
        string[] game = new string[15] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        playerData Harry = new playerData("Harry");
        Harry.addMove("1. e4 d6");
        Harry.addMove("1. e4 d7");
        Harry.addMove("1. e4 d8");
        Assert.AreEqual("1. e4 d6", Harry.currentgame[0]);
        Harry.addGame();
        Assert.AreEqual("1. e4 d6 1. e4 d7 1. e4 d8", Harry.getGameAt(0));
    }
    [Test]
    public void GameStorageTest()
    {
        string[] game = new string[15] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        playerData Harry = new playerData("Harry");
        Harry.addMove("1. e4 d6");
        Harry.addMove("1. e4 d7");
        Harry.addMove("1. e4 d8");
        Assert.AreEqual("1. e4 d6", Harry.currentgame[0]);
        Harry.addGame();
        Assert.AreEqual("1. e4 d6 1. e4 d7 1. e4 d8", Harry.getGameAt(0));
    }
}
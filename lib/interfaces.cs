﻿namespace lib;
public interface IaddGames
{
    public void findGame(int game, playerData player)
    {
        player.getGameAt(game);
    }
}
public abstract class ChessGame
{
    public abstract string getGameAt(int i);
}
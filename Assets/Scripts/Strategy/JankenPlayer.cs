using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankenPlayer
{
    private string name;
    private Strategy strategy;
    private int wincount;
    private int losecount;
    private int gamecount;
    public JankenPlayer(string name, Strategy strategy)
    {
        this.name = name;
        this.strategy = strategy;
    }
    public Hand NextHand()
    {
        return strategy.NextHand();
    }
    public void Win()
    {
        strategy.Study(true);
        wincount++;
        gamecount++;
    }
    public void Lose()
    {
        strategy.Study(false);
        losecount++;
        gamecount++;
    }
    public void Even()
    {
        gamecount++;
    }
    public string ToStringResult()
    {
        return "[" + name + ":" + gamecount + " games, " + wincount + " win, " + losecount + " lose" + "]";
    }
}

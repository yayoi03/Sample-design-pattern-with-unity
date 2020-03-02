using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WinningStrategy : Strategy
{
    private System.Random random;
    private bool won = false;
    private Hand prevHand;
    public WinningStrategy(int seed)
    {
        random = new System.Random(seed);
    }
    public Hand NextHand()
    {
        if (!won)
        {
            prevHand = Hand.GetHand(random.Next(3));
        }
        return prevHand;
    }
    public void Study(bool win)
    {
        won = win;
    }
}


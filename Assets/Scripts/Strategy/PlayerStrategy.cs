using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class PlayerStrategy:MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
            int seed1 = num1;
            int seed2 = num2;
            JankenPlayer player1 = new JankenPlayer("Taro", new WinningStrategy(seed1));
            JankenPlayer player2 = new JankenPlayer("Hana", new ProbStrategy(seed2));
            for (int i = 0; i < 10; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();
                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Debug.Log("Winner:" + player1.ToStringResult());
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Debug.Log("Winner:" + player2.ToStringResult());
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Debug.Log("Even...");
                    player1.Even();
                    player2.Even();
                }
            }
            Debug.Log("Total result:");
            Debug.Log(player1.ToStringResult());
            Debug.Log(player2.ToStringResult());
            
        
    }
}


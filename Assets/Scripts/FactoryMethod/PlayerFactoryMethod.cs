using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using framework;
using idcard;

public class PlayerFactoryMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Factory factory = new IDCardFactory();
        Product card1 = factory.Create("山田");
        Product card2 = factory.Create("小田原");
        Product card3 = factory.Create("勅使河原");
        card1.Use();
        card2.Use();
        card3.Use();
    }
}

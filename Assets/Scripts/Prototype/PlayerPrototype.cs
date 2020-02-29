using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using frameworkPrototype;

public class PlayerPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 準備
        Manager manager = new Manager();
        UnderlinePen upen = new UnderlinePen('~');
        MessageBox mbox = new MessageBox('*');
        MessageBox sbox = new MessageBox('/');
        manager.Register("strong message", upen);
        manager.Register("warning box", mbox);
        manager.Register("slash box", sbox);


        // 生成
        ProductPrototype p1 = manager.Create("strong message");
        p1.Use("Hello, world.");
        ProductPrototype p2 = manager.Create("warning box");
        p2.Use("Hello, world.");
        ProductPrototype p3 = manager.Create("slash box");
        p3.Use("Hello, world.");
        
    }

}



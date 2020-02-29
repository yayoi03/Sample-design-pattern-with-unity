using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start.");
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();
        
        if (obj1 == obj2)
        {
            Debug.Log("obj1とobj2は同じインスタンスです。");
        }
        else
        {
            Debug.Log("obj1とobj2は同じインスタンスではありません。");
        }
        Debug.Log("End.");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private static Singleton singleton = new Singleton();
    private Singleton()
    {
        Debug.Log("インスタンスを生成しました。");
    }
    public static Singleton GetInstance()
    {
        return singleton;
    }
}


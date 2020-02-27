using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banner
{
    private string _string;
    public Banner(string _string)
    {
        this._string = _string;
    }
    public void ShowWithParen()
    {
        Debug.Log("(" + _string + ")");
    }
    public void ShowWithAster()
    {
        Debug.Log("*" + _string + "*");
    }
}

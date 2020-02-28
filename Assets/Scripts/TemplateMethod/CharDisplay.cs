using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharDisplay : AbstractDisplay
{
    private char ch;
    public CharDisplay(char ch)
    {
        this.ch = ch;
    }
    public override void Open()
    {
        Debug.Log("<<");
    }
    public override void Print()
    {
        Debug.Log(ch);
    }
    public override void Close()
    {
        Debug.Log(">>");
    }
}


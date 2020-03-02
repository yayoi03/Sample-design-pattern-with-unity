using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringDisplayImpl : DisplayImpl
{
    private string _string;
    private int width;
    public StringDisplayImpl(string _string)
    {
        this._string = _string;
        this.width = _string.Length;
    }
    public override void RawOpen()
    {
        PrintLine();
    }
    public override void rawPrint()
    {
        Debug.Log("|" + _string + "|");
    }
    public override void RawClose()
    {
        PrintLine();
    }
    private void PrintLine()
    {
        string line="";
        line += "+";
        for (int i = 0; i < width; i++)
        {
            line += "-";
        }
        line += "+";

        Debug.Log(line);
    }
}

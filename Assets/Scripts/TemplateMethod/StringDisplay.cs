using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringDisplay : AbstractDisplay
{    
    private string _string;                              
    private int width;                                  
public StringDisplay(string _string)
{              
    this._string = _string;                          
    this.width = _string.Length;          
}
    public override void Open()
    {
        PrintLine();
    }                             
public override void Print()
{                              
    Debug.Log("|" + _string + "|");        
}
public override void Close()
{                              
    PrintLine();                                   
}
private void PrintLine()
{                         
    Debug.Log("+");                          
    for (int i = 0; i < width; i++)
    {               
        Debug.Log("-");                      
    }
    Debug.Log("+");                     
}
}


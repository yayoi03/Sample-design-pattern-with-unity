using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractDisplay
{
    public abstract void Open();       
    public abstract void Print();       
    public abstract void Close();      
    public void display()
    {       
        Open();                             
        for (int i = 0; i < 5; i++)
        {
            Print();
        }
        Close();                            
    }
}

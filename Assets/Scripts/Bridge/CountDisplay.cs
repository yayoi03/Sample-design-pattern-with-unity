using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDisplay : Display
{
    public CountDisplay(DisplayImpl impl) : base(impl){}
    public void MultiDisplay(int times)
    {       
        Open();
        for (int i = 0; i < times; i++)
        {
            Print();
        }
        Close();
    }
}


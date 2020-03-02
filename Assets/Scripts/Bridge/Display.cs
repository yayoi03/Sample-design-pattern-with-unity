using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display
{
    private DisplayImpl impl;
    public Display(DisplayImpl impl)
    {
        this.impl = impl;
    }
    public void Open()
    {
        impl.RawOpen();
    }
    public void Print()
    {
        impl.rawPrint();
    }
    public void Close()
    {
        impl.RawClose();
    }
    public void Singledisplay()
    {
        Open();
        Print();
        Close();
    }
}


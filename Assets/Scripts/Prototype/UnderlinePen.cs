using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using frameworkPrototype;


public class UnderlinePen : ProductPrototype
{
    private char ulchar;
    public UnderlinePen(char ulchar)
    {
        this.ulchar = ulchar;
    }
    public void Use(string s)
    {
        int length = s.Length;
        string underline = "";
        Debug.Log("\"" + s + "\"");
        
        for (int i = 0; i < length; i++)
        {
            underline += ulchar;
        }

        Debug.Log(underline);
        
    }
    public ProductPrototype CreateClone()
    {
        ProductPrototype p = null;

        p = (ProductPrototype)this.MemberwiseClone();

        return p;
    }
}
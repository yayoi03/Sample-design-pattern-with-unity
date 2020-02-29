using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using frameworkPrototype;


public class MessageBox : ProductPrototype
{
    private char decochar;
    public MessageBox(char decochar)
    {
        this.decochar = decochar;
    }
    public void Use(string s)
    {
        int length = s.Length;
        string up = "";
        string down = "";
        for (int i = 0; i < length + 4; i++)
        {
            up += decochar;
        }

        Debug.Log(up);

        Debug.Log(decochar + " " + s + " " + decochar);


        for (int i = 0; i < length + 4; i++)
        {
            down += decochar;
        }

        Debug.Log(down);
    }

    public ProductPrototype CreateClone()
    {
        ProductPrototype p = null;

        p = (ProductPrototype)this.MemberwiseClone();

        return p;
    }

}


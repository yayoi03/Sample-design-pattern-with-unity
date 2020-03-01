using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director
{
    private Builder builder;
    public Director(Builder builder)
    {      
        this.builder = builder;             
    }
    public void Construct()
    {            
        builder.MakeTitle("Greeting");              
        builder.MakeString("朝から昼にかけて");     
        builder.MakeItems(new string[]{             
            "おはようございます。",
            "こんにちは。",
        });
        builder.MakeString("夜に");                
        builder.MakeItems(new string[]{             
            "こんばんは。",
            "おやすみなさい。",
            "さようなら。",
        });
        builder.Close();                
    }
}


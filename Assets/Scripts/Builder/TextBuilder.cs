using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class TextBuilder : Builder
{
    private StringBuilder sbText = new StringBuilder();           
    public override void MakeTitle(string title)
    {                       
        sbText.Append("==============================\n");         
        sbText.Append("『" + title + "』\n");                       
        sbText.Append("\n");                                        
    }
    public override void MakeString(string str)
    {                        
        sbText.Append('■' + str + "\n");                           
        sbText.Append("\n");                                        
    }
    public override void MakeItems(string[] items)
    {                     
        for (int i = 0; i < items.Length; i++)
        {
            sbText.Append("　・" + items[i] + "\n");               
        }
        sbText.Append("\n");                                       
    }
    public override void Close()
    {                                      
        sbText.Append("==============================\n");        
    }
    public string GetResult()
    {                               
        return sbText.ToString();                                   
    }
}


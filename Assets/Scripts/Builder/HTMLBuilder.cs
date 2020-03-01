using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class HTMLBuilder : Builder
{
    private StringBuilder sbHTML = new StringBuilder();
    public override void MakeTitle(string title)
    {  
        sbHTML.Append("<html><head><title>" + title + "</title></head><body>");   
        sbHTML.Append("\n");
        sbHTML.Append("<h1>" + title + "</h1>");
        sbHTML.Append("\n");
    }
    public override void MakeString(string str)
    {                       
        sbHTML.Append("<p>" + str + "</p>");
        sbHTML.Append("\n");
    }
    public override void MakeItems(string[] items)
    {                    
        sbHTML.Append("<ul>");
        sbHTML.Append("\n");
        for (int i = 0; i < items.Length; i++)
        {
            sbHTML.Append("<li>" + items[i] + "</li>");
            sbHTML.Append("\n");
        }
        sbHTML.Append("</ul>");
        sbHTML.Append("\n");
    }
    public override void Close()
    {                                      
        sbHTML.Append("</body></html>");  
    }
    public string GetResult()
    {                                
        return sbHTML.ToString();                                           
    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//継承を使ったもの
public class PrintBanner : Banner, Print
{
    public PrintBanner(string _string) : base(_string)
    {

    }
    public void PrintWeak()
    {
        ShowWithParen();
    }
    public void PrintStrong()
    {
        ShowWithAster();
    }
}

//委譲を使ったもの

//public class PrintBanner :  Print
//{
//    private Banner banner;
//    public PrintBanner(string _string) 
//    {
//        this.banner = new Banner(_string);
//    }
//    public override void PrintWeak()
//    {
//        banner.ShowWithParen();
//    }
//    public  override void PrintStrong()
//    {
//        banner.ShowWithAster();
//    }
//}
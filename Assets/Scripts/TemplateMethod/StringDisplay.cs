using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringDisplay : AbstractDisplay
{    // StringDisplayも、AbstractDisplayのサブクラス。
    private string _string;                              // 表示するべき文字列。
    private int width;                                  // バイト単位で計算した文字列の「幅」。
public StringDisplay(string _string)
{               // コンストラクタで渡された文字列stringを、
    this._string = _string;                           // フィールドに記憶。
    this.width = _string.Length;          // それからバイト単位の幅もフィールドに記憶しておいて、後で使う。
}
public override void Open()
{                                // オーバーライドして定義するopenメソッド。
    PrintLine();                                    // このクラスのメソッドprintLineで線を引いている。
}
public override void Print()
{                               // printメソッドは、
    Debug.Log("|" + _string + "|");         // フィールドに記憶しておいた文字列の前後に"|"をつけて表示。
}
public override void Close()
{                               // closeメソッドは、
    PrintLine();                                    // openと同じくprintLineメソッドで線を引いている。
}
private void PrintLine()
{                          // openとcloseから呼ばれるprintLineメソッドだ。privateなので、このクラスの中だけで使われる。
    Debug.Log("+");                          // 枠の角を表現する"+"マークを表示。
    for (int i = 0; i < width; i++)
    {               // width個の"-"を表示して、
        Debug.Log("-");                      // 枠線として用いる。
    }
    Debug.Log("+");                        // 枠の角を表現する"+"マークを表示。
}
}


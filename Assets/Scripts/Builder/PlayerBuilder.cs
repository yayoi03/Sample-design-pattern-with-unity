using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuilder : MonoBehaviour
{
    [SerializeField] string fileName="noname";

    // Start is called before the first frame update
    void Start()
    {
        if (fileName=="plain")
        {
            TextBuilder textbuilder = new TextBuilder();
            Director director = new Director(textbuilder);
            director.Construct();
            string result = textbuilder.GetResult();
            Debug.Log(result);
        }
        else if (fileName=="html")
        {
            HTMLBuilder htmlbuilder = new HTMLBuilder();
            Director director = new Director(htmlbuilder);
            director.Construct();
            string result = htmlbuilder.GetResult();
            Debug.Log(result);
        }
        else
        {
            Debug.Log("\"plain\"か\"html\"をfileNameに入力して下さい。");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}


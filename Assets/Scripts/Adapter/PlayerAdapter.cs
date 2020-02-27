using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAdapter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Print p = new PrintBanner("Hello");
        p.PrintWeak();
        p.PrintStrong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

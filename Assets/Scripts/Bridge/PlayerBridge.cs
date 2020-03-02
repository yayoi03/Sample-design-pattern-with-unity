using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBridge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
        Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
        CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));
        d1.Singledisplay();
        d2.Singledisplay();
        d3.Singledisplay();
        d3.MultiDisplay(5);
    }

}

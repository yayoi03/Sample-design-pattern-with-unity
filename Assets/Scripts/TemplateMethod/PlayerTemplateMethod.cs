using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTemplateMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AbstractDisplay d1 = new CharDisplay('A');                  
        AbstractDisplay d2 = new StringDisplay("Hello");   
        AbstractDisplay d3 = new StringDisplay("おはようございます");     
        d1.display();                                              
        d2.display();                                              
        d3.display();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace frameworkPrototype
{
    public interface ProductPrototype 
    {
        void Use(string s);
        ProductPrototype CreateClone();
        
    }
}




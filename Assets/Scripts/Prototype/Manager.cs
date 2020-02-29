using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace frameworkPrototype
{
    public class Manager
    {
        private Dictionary<string,ProductPrototype> showcase = new Dictionary<string, ProductPrototype>();
        public void Register(string name, ProductPrototype proto)
        {
            showcase.Add(name, proto);
        }
        public ProductPrototype Create(string protoname)
        {
            ProductPrototype p = (ProductPrototype)showcase[protoname];
            return p.CreateClone();
        }
    }
}




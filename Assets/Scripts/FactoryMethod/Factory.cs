using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace framework
{  
    public abstract class Factory
    {
        public  Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product product);
    }

}

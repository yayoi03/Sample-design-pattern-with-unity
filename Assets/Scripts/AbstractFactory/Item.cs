using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace factory
{
    public abstract class Item
    {
        protected string caption;
        public Item(string caption)
        {
            this.caption = caption;
        }
        public abstract string MakeHTML();
    }

}
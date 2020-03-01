using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace factory
{
    public abstract class Link : Item
    {
        protected string url;
        public Link(string caption, string url) : base(caption)
        {
            this.url = url;
        }
    }

}

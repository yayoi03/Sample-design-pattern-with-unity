using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using framework;

namespace idcard
{
    public class IDCard : Product
    {
        private string owner;
        public IDCard(string owner)
        {
            Debug.Log(owner + "のカードを作ります。");
            this.owner = owner;
        }
        public override void Use()
        {
            Debug.Log(owner + "のカードを使います。");
        }
        public string GetOwner()
        {
            return owner;
        }
    }
}


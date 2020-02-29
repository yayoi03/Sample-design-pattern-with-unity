using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using framework;

namespace idcard
{
    public class IDCardFactory : Factory
    {
        private List<string> owners = new List<string>();
        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }
        protected override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product).GetOwner());
        }
        public List<string> GetOwners()
        {
            return owners;
        }
    }
}

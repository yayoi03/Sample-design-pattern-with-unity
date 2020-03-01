﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace factory
{
    public abstract class Tray : Item
    {
        protected List<Item> tray = new List<Item>();
        public Tray(string caption):base(caption)
    {
       
    }
    public void Add(Item item)
    {
        tray.Add(item);
    }
}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Reflection;
using listfactory;
using System;

namespace factory
{
    public abstract class FactoryAF
    {
        public static FactoryAF GetFactory(string classname)
        {
            FactoryAF factory = null;
           
            factory = (FactoryAF)Activator.CreateInstance(Type.GetType("listfactory."+classname));

            return factory;
        }
        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}



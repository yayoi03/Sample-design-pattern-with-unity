﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using factory;

namespace listfactory
{

    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url) { }

        public override string MakeHTML()
        {
            return $"  <li><a href=\"{url}\">{caption}</a></li>\n";
        }
    }
}

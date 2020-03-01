using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using factory;


namespace listfactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<li>\n");
            sb.Append($"{caption}\n");
            sb.Append("<ul>\n");
            IEnumerator<Item> e = tray.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("</ul>\n");
            sb.Append("</li>\n");
            return sb.ToString();
        }
    }
}

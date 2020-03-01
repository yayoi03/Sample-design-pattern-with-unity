using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using factory;



namespace listfactory
{

    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {

        }
        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><head><title>{title}</title></head>\n");
            sb.Append("<body>\n");
            sb.Append($"<h1>{title}</h1>");
            sb.Append("<ul>\n");
            IEnumerator<Item> e = content.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("</ul>\n");
            sb.Append($"<hr><address>{author}</address>");
            sb.Append("</body></html>\n");
            return sb.ToString();
        }
    }
}

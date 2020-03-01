using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;


namespace factory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            this.content.Add(item);
        }

        public void Output()
        {
            string filename = title + ".html";
            
            Debug.Log(this.MakeHTML());
            
            Debug.Log($"{filename}を作成しました。");
        }
        public abstract string MakeHTML();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using factory;
using listfactory;

public class PlayerAF : MonoBehaviour
{
    [SerializeField] string nameAF;
    // Start is called before the first frame update
    void Start()
    {
        FactoryAF factory = FactoryAF.GetFactory(nameAF);
        //Debug.Log(factory.GetType().Name);
        Link asahi = factory.CreateLink("朝日新聞", "http://www.asashi.com/");
        Link yomiuri = factory.CreateLink("読売新聞", "http://www.yomiuri.co.jp/");

        Link usYahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
        Link jpYahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
        Link excite = factory.CreateLink("Excite", "http://www.excite.co.jp/");
        Link google = factory.CreateLink("Google", "http://www.google.com/");

        Tray traynews = factory.CreateTray("新聞");
        traynews.Add(asahi);
        traynews.Add(yomiuri);

        Tray trayyahoo = factory.CreateTray("Yahoo!");
        trayyahoo.Add(usYahoo);
        trayyahoo.Add(jpYahoo);

        Tray traysearch = factory.CreateTray("サーチエンジン");
        traysearch.Add(trayyahoo);
        traysearch.Add(excite);
        traysearch.Add(google);

        Page page = factory.CreatePage("LinkPage", "Yamada");
        page.Add(traynews);
        page.Add(traysearch);
        page.Output();
    }

   
}

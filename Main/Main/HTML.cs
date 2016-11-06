using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

static class HTML
{
    public static string GetTitleTag(HtmlDocument doc)
    {
        var innerText = doc.DocumentNode.Descendants("title").Select(x => x.InnerText).FirstOrDefault();
        return innerText;
    }

    public static string GetMetaTag(HtmlDocument doc, string lCaseProp, string uCaseProp)
    {
        string data = string.Empty;

        if (doc.DocumentNode.HasChildNodes)
        {
            var metaNodes = doc.DocumentNode.SelectNodes("//meta");

            if (metaNodes.Count > 0)
            {
                foreach (HtmlNode node in metaNodes)
                {
                    if (node.HasAttributes)
                    {
                        var desc = node.Attributes.AttributesWithName("property").Where(x => x.Value.Contains(lCaseProp) || x.Value.Contains(uCaseProp)).FirstOrDefault();
                        if (desc == null) { desc = node.Attributes.AttributesWithName("name").Where(x => x.Value.Contains(lCaseProp) || x.Value.Contains(uCaseProp)).FirstOrDefault(); }
                        if (desc == null) { desc = node.Attributes.AttributesWithName("Property").Where(x => x.Value.Contains(lCaseProp) || x.Value.Contains(uCaseProp)).FirstOrDefault(); }
                        if (desc == null) { desc = node.Attributes.AttributesWithName("Name").Where(x => x.Value.Contains(lCaseProp) || x.Value.Contains(uCaseProp)).FirstOrDefault(); }

                        if (desc != null)
                        {
                            data = node.Attributes.AttributesWithName("content").FirstOrDefault().Value + " " + data;
                        }
                    }
                }
            }
        }

        return data;
    }

    public static HtmlDocument GetHTML(string url)
    {
        var htmlWeb = new HtmlWeb();
        htmlWeb.OverrideEncoding = Encoding.UTF8;

        try
        {
            var doc = htmlWeb.Load(url);
            return doc;
        }
        catch (WebException ex)
        {
            try
            {
                htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.87 Safari/537.36";
                var doc = htmlWeb.Load(url);
                return doc;
            }
            catch
            {
                Console.WriteLine(ex.Message);
                return new HtmlDocument();
            }
        }

    }
}


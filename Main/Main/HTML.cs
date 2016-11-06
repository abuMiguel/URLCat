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
    public static string GetTitleTag(string html)
    {
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);

        var innerText = doc.DocumentNode.Descendants("title").Select(x => x.InnerText).FirstOrDefault();

        return innerText;
    }

    public static string GetMetaTag(string html, string property)
    {
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);
        string data = string.Empty;

        foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//meta"))
        {
            var desc = node.Attributes.AttributesWithName("property").Where(x => x.Value.Contains(property)).FirstOrDefault();
            if( desc == null) { desc = node.Attributes.AttributesWithName("name").Where(x => x.Value.Contains(property)).FirstOrDefault(); }

            if (desc != null)
            {
                data = node.Attributes.AttributesWithName("content").FirstOrDefault().Value;
            }
        }

        return data;
    }

    public static string GetHTML(string url)
    {
        string urlAddress = url;
        string data = string.Empty;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        if (response.StatusCode == HttpStatusCode.OK)
        {
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = null;

            if (response.CharacterSet == null)
            {
                readStream = new StreamReader(receiveStream);
            }
            else
            {
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            }

            data = readStream.ReadToEnd();

            response.Close();
            readStream.Close();


        }
        return data;
    }
}


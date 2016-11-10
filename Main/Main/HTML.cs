using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class HTML
{
    public HtmlDocument doc { get; set; } = new HtmlDocument();
    public string url { get; set; } = string.Empty;
    public string title { get; set; } = string.Empty;
    public string metaDescription { get; set; } = string.Empty;
    public string metaKeywords { get; set; } = string.Empty;


    public HTML(string input)
    {
        this.url = input;
        FormatURL();
        HtmlWeb web = new HtmlWeb();
        web.OverrideEncoding = Encoding.UTF8;

        try
        {
            doc = web.Load(url);
            this.title = GetTitleTag();
            this.metaDescription = GetMetaTag("description");
            this.metaKeywords = GetMetaTag("keywords");
        }
        catch (WebException ex)
        {
            try
            {
                web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.87 Safari/537.36";
                doc = web.Load(url);
                this.title = GetTitleTag();
                this.metaDescription = GetMetaTag("description");
                this.metaKeywords = GetMetaTag("keywords");
            }
            catch
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public HTML(string input, string html)
    {
        this.url = input;
        FormatURL();

        try
        {
            doc.LoadHtml(html);
            this.title = GetTitleTag();
            this.metaDescription = GetMetaTag("description");
            this.metaKeywords = GetMetaTag("keywords");
        }
        catch { }
    }

    public string GetTitleTag()
    {
        var innerText = doc.DocumentNode.Descendants("title").Select(x => x.InnerText).FirstOrDefault();
        return innerText;
    }

    public string GetMetaTag(string property)
    {
        string lCaseProp = property;
        string uCaseProp = property[0].ToString().ToUpper() + property.Remove(0,1);
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

    public string GetTopLevelDomain()
    {
        Uri website = new Uri(this.url);
        var host = website.Host;
        var index = host.LastIndexOf('.');
        var domain = host.Substring(index + 1);

        return domain;
    }

    private void FormatURL()
    {
        if (!this.url.StartsWith("https://") && !this.url.StartsWith("http://"))
        { 
            this.url = "http://" + this.url;
        }

    }
}


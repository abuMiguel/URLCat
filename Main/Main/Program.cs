using HtmlAgilityPack;
using Main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Enums;
using static Keyword;

namespace URLCategorize
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Write("Enter URL: ");
                    var input = Console.ReadLine();
                    var data = new Data();
                    var html = new HTML(input);
                    var results = new Result(html, data);

                    var titleResult = results.titleMatches.FirstOrDefault(x => x.Value == results.titleMatches.Values.Max());
                    var metaDescriptionResult = results.metaDescriptionMatches.FirstOrDefault(x => x.Value == results.metaDescriptionMatches.Values.Max());
                    var metaKeywordsResult = results.metaKeywordsMatches.FirstOrDefault(x => x.Value == results.metaKeywordsMatches.Values.Max());
                    var domainResult = results.GetDomainResult(html, data.domains);

                    Console.WriteLine("title results: " + titleResult.Key.ToString() + " " + titleResult.Value.ToString());
                    Console.WriteLine("meta description results: " + metaDescriptionResult.Key.ToString() + " " + metaDescriptionResult.Value.ToString());
                    Console.WriteLine("meta keywords results: " + metaKeywordsResult.Key.ToString() + " " + metaKeywordsResult.Value.ToString());
                    Console.WriteLine("domain result: " + domainResult.ToString());
                    Console.WriteLine("");
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }

        
    }

}
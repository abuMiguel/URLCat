using HtmlAgilityPack;
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
        static List<Keyword> keywords = new List<Keyword>();

        static void Main(string[] args)
        {
            LoadKeywords();

            Console.Write("Enter URL: ");
            var input = Console.ReadLine();
            input = FormatURL(input);

            var html = HTML.GetHTML(input);
            var title = HTML.GetTitleTag(html);
            var metaDescription = HTML.GetMetaTag(html, "description");
            var metaKeywords = HTML.GetMetaTag(html, "keywords");

            var titleMatchResults = GetMatchResults(title);
            var metaDescriptionMatchResults = GetMatchResults(metaDescription);
            var metaKeywordsMatchResults = GetMatchResults(metaKeywords);

            var titleResult = titleMatchResults.FirstOrDefault(x => x.Value == titleMatchResults.Values.Max());
            var metaDescriptionResult = metaDescriptionMatchResults.FirstOrDefault(x => x.Value == metaDescriptionMatchResults.Values.Max());
            var metaKeywordsResult = metaKeywordsMatchResults.FirstOrDefault(x => x.Value == metaKeywordsMatchResults.Values.Max());

            //var total = new Dictionary<Categories, int>();
            //total.Add(titleResult.Key, titleResult.Value);
            //total.Add(metaDescriptionResult.Key, metaDescriptionResult.Value);
            //total.Add(metaKeywordsResult.Key, metaKeywordsResult.Value);

            Console.WriteLine("title results: " + titleResult.Key.ToString() + " " + titleResult.Value.ToString());
            Console.WriteLine("meta property results: " + metaDescriptionResult.Key.ToString() + " " + metaDescriptionResult.Value.ToString());
            Console.WriteLine("meta keywords results: " + metaKeywordsResult.Key.ToString() + " " + metaKeywordsResult.Value.ToString());
            Console.WriteLine("");
 
            Console.ReadKey();
        }

        static string FormatURL(string url)
        {
            if(url.StartsWith("http://") || url.StartsWith("https://"))
            {
                return url;
            }
            else
            {
                url = "http://" + url;
            }
            return url;
        }
        
        static Dictionary<Categories, int> GetMatchResults(string words)
        {
            Dictionary<Categories, int> results = new Dictionary<Categories, int>();

            foreach (Categories cat in Enum.GetValues(typeof(Categories)))
            {
                results.Add(cat, 0);
            }

            List<string> wordList = Tokenize(words);

            //match individual tokenized words
            foreach (var word in wordList)
            {
                var w = word.ToLower();

                foreach (var keyword in keywords)
                {
                    if (w == keyword.word) { results[keyword.cat]++; }
                }

            }

            //match phrases

            return results;
        }

        static List<string> Tokenize(string words)
        {
            List<string> wordList = new List<string>();
            List<string> tokenizedWords = new List<string>();

            //split words by spaces
            wordList = words.Split().ToList();

            //get rid of commas
            foreach(var word in wordList)
            {
                if(word.EndsWith(","))
                {
                    tokenizedWords.Add(word.TrimEnd(','));
                }
                else if (word.EndsWith("."))
                {
                    tokenizedWords.Add(word.TrimEnd('.'));
                }
                else if (word.EndsWith(":"))
                {
                    tokenizedWords.Add(word.TrimEnd(':'));
                }
                else
                {
                    tokenizedWords.Add(word);
                }
            }

            return tokenizedWords;
        }


        static void LoadKeywords()
        {
            keywords.Add(new Keyword("sports", Categories.Sports));
            keywords.Add(new Keyword("basketball", Categories.Sports));
            keywords.Add(new Keyword("football", Categories.Sports));
            keywords.Add(new Keyword("soccer", Categories.Sports));
            keywords.Add(new Keyword("hockey", Categories.Sports));

            keywords.Add(new Keyword("news", Categories.News));

            keywords.Add(new Keyword("computer", Categories.Technology));
            keywords.Add(new Keyword("computers", Categories.Technology));
            keywords.Add(new Keyword("laptop", Categories.Technology));
            keywords.Add(new Keyword("laptops", Categories.Technology));
            keywords.Add(new Keyword("technology", Categories.Technology));
            keywords.Add(new Keyword("tech", Categories.Technology));
            keywords.Add(new Keyword("software", Categories.Technology));
            keywords.Add(new Keyword("phone", Categories.Technology));
            keywords.Add(new Keyword("smartphone", Categories.Technology));
            keywords.Add(new Keyword("mobile", Categories.Technology));
            keywords.Add(new Keyword("app", Categories.Technology));

            keywords.Add(new Keyword("celebrity", Categories.Entertainment));
            keywords.Add(new Keyword("entertainment", Categories.Entertainment));
            keywords.Add(new Keyword("games", Categories.Entertainment));
            keywords.Add(new Keyword("game", Categories.Entertainment));
            keywords.Add(new Keyword("television", Categories.Entertainment));
            keywords.Add(new Keyword("tv", Categories.Entertainment));
            keywords.Add(new Keyword("shows", Categories.Entertainment));
            keywords.Add(new Keyword("episodes", Categories.Entertainment));
            keywords.Add(new Keyword("watch", Categories.Entertainment));
            keywords.Add(new Keyword("video", Categories.Entertainment));

            keywords.Add(new Keyword("money", Categories.Finance));
            keywords.Add(new Keyword("finance", Categories.Finance));
            keywords.Add(new Keyword("finances", Categories.Finance));

            keywords.Add(new Keyword("blog", Categories.Blog));
            keywords.Add(new Keyword("blogs", Categories.Blog));
            keywords.Add(new Keyword("vlog", Categories.Blog));

            keywords.Add(new Keyword("travel", Categories.Travel));

            keywords.Add(new Keyword("fashion", Categories.Fashion));
            keywords.Add(new Keyword("hair", Categories.Fashion));

            keywords.Add(new Keyword("porn", Categories.Adult));
            keywords.Add(new Keyword("xxx", Categories.Adult));
            keywords.Add(new Keyword("sex", Categories.Adult));
            keywords.Add(new Keyword("pussy", Categories.Adult));
            keywords.Add(new Keyword("porno", Categories.Adult));
            keywords.Add(new Keyword("fuck", Categories.Adult));


        }
    }

}
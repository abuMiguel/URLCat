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
        static List<Keyword> phrases = new List<Keyword>();
        static List<Keyword> domains = new List<Keyword>();

        static void Main(string[] args)
        {
            LoadKeywords();
            LoadPhrases();
            LoadDomains();
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Write("Enter URL: ");
                    var input = Console.ReadLine();
                    input = FormatURL(input);

                    var html = HTML.GetHTML(input);
                    var title = HTML.GetTitleTag(html);
                    var metaDescription = HTML.GetMetaTag(html, "description", "Description");
                    var metaKeywords = HTML.GetMetaTag(html, "keywords", "Keywords");

                    var titleMatchResults = GetMatchResults(title);
                    var metaDescriptionMatchResults = GetMatchResults(metaDescription);
                    var metaKeywordsMatchResults = GetMatchResults(metaKeywords);

                    var titleResult = titleMatchResults.FirstOrDefault(x => x.Value == titleMatchResults.Values.Max());
                    var metaDescriptionResult = metaDescriptionMatchResults.FirstOrDefault(x => x.Value == metaDescriptionMatchResults.Values.Max());
                    var metaKeywordsResult = metaKeywordsMatchResults.FirstOrDefault(x => x.Value == metaKeywordsMatchResults.Values.Max());

                    var domainResult = GetDomainResult(input);

                    Console.WriteLine("title results: " + titleResult.Key.ToString() + " " + titleResult.Value.ToString());
                    Console.WriteLine("meta description results: " + metaDescriptionResult.Key.ToString() + " " + metaDescriptionResult.Value.ToString());
                    Console.WriteLine("meta keywords results: " + metaKeywordsResult.Key.ToString() + " " + metaKeywordsResult.Value.ToString());
                    Console.WriteLine("domain result: " + domainResult.ToString());
                    Console.WriteLine("");

                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            
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

        static Categories GetDomainResult(string url)
        {
            var domain = HTML.GetTopLevelDomain(url);
            Categories cat = Categories.Unknown;

            foreach(var d in domains)
            {
                if(domain == d.word) { cat = d.cat; }
            }

            return cat;
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
            foreach (var phrase in phrases)
            {
                var wordsLowerCase = words.ToLower();
                
                if (wordsLowerCase.Contains(phrase.word)) { results[phrase.cat]++; }
            }

            return results;
        }

        static List<string> Tokenize(string words)
        {
            List<string> wordList = new List<string>();
            List<string> tokenizedWords = new List<string>();

            if (string.IsNullOrEmpty(words)) { return wordList; }

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
            keywords.Add(new Keyword("golf", Categories.Sports));
            keywords.Add(new Keyword("tennis", Categories.Sports));
            keywords.Add(new Keyword("baseball", Categories.Sports));
            keywords.Add(new Keyword("nba", Categories.Sports));
            keywords.Add(new Keyword("nfl", Categories.Sports));
            keywords.Add(new Keyword("mlb", Categories.Sports));

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
            keywords.Add(new Keyword("music", Categories.Entertainment));
            keywords.Add(new Keyword("songs", Categories.Entertainment));

            keywords.Add(new Keyword("money", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("finance", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("finances", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("financial", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("stock", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("stocks", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("mortgage", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("loans", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("refinance", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("credit", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("investment", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("insurance", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("bank", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("banks", Categories.FinanceAndInvestment));
            keywords.Add(new Keyword("business", Categories.FinanceAndInvestment));


            keywords.Add(new Keyword("blog", Categories.Blog));
            keywords.Add(new Keyword("blogs", Categories.Blog));
            keywords.Add(new Keyword("vlog", Categories.Blog));
            keywords.Add(new Keyword("blogger", Categories.Blog));
            keywords.Add(new Keyword("blogging", Categories.Blog));

            keywords.Add(new Keyword("politics", Categories.Politics));
            keywords.Add(new Keyword("republican", Categories.Politics));
            keywords.Add(new Keyword("democrat", Categories.Politics));
            keywords.Add(new Keyword("vote", Categories.Politics));
            keywords.Add(new Keyword("voting", Categories.Politics));
            keywords.Add(new Keyword("political", Categories.Politics));
            keywords.Add(new Keyword("politician", Categories.Politics));

            keywords.Add(new Keyword("search", Categories.SearchEngine));
            keywords.Add(new Keyword("searching", Categories.SearchEngine));

            keywords.Add(new Keyword("travel", Categories.Travel));

            keywords.Add(new Keyword("fashion", Categories.FashionAndBeauty));
            keywords.Add(new Keyword("hair", Categories.FashionAndBeauty));

            keywords.Add(new Keyword("shopping", Categories.Shopping));
            keywords.Add(new Keyword("deals", Categories.Shopping));
            keywords.Add(new Keyword("savings", Categories.Shopping));

            keywords.Add(new Keyword("government", Categories.Government));
            keywords.Add(new Keyword("agency", Categories.Government));
            keywords.Add(new Keyword("agencies", Categories.Government));

            keywords.Add(new Keyword("porn", Categories.Adult));
            keywords.Add(new Keyword("xxx", Categories.Adult));
            keywords.Add(new Keyword("sex", Categories.Adult));
            keywords.Add(new Keyword("pussy", Categories.Adult));
            keywords.Add(new Keyword("porno", Categories.Adult));
            keywords.Add(new Keyword("pornstar", Categories.Adult));
            keywords.Add(new Keyword("pornstars", Categories.Adult));
            keywords.Add(new Keyword("fuck", Categories.Adult));
            keywords.Add(new Keyword("pornvideos", Categories.Adult));
            keywords.Add(new Keyword("pornvideo", Categories.Adult));
        }

        static void LoadPhrases()
        {
            phrases.Add(new Keyword("black friday", Categories.Shopping));
        }

        static void LoadDomains()
        {
            domains.Add(new Keyword("edu", Categories.Education));
            domains.Add(new Keyword("gov", Categories.Government));
            domains.Add(new Keyword("mil", Categories.Military));
            domains.Add(new Keyword("xxx", Categories.Adult));
        }
    }

}
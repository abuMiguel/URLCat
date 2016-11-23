using System;
using System.Collections.Generic;
using System.Linq;
using static Enums;
using static Main.Data;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Main
{
    public class Result
    {
        public Dictionary<Categories, int> titleMatches { get; set; } = new Dictionary<Categories, int>();
        public Dictionary<Categories, int> metaDescriptionMatches { get; set; } = new Dictionary<Categories, int>();
        public Dictionary<Categories, int> metaKeywordsMatches { get; set; } = new Dictionary<Categories, int>();
        public KeyValuePair<Categories, int> titleTopResult { get; set; } = new KeyValuePair<Categories, int>();
        public KeyValuePair<Categories, int> metaDescriptionTopResult { get; set; } = new KeyValuePair<Categories, int>();
        public KeyValuePair<Categories, int> metaKeywordsTopResult { get; set; } = new KeyValuePair<Categories, int>();
        public Categories domainResult { get; set; } = Categories.Unknown;
        public Categories urlResult { get; set; } = Categories.Unknown;

        public Result(HTML html, Data data)
        {
            bool camelTitle = IsCamelCase(html.title);
            html.title = camelTitle ? SplitCamelCase(html.title) : html.title;

            this.titleMatches = GetMatchResults(html.title, data);
            this.metaDescriptionMatches = GetMatchResults(html.metaDescription, data);
            this.metaKeywordsMatches = GetMatchResults(html.metaKeywords, data);
            this.domainResult = GetDomainResult(html, data.domains);
            this.urlResult = GetURLResult(html, data.urlKeywords);
            this.SetTopResults(html, data);
        }

        private void SetTopResults(HTML html, Data data)
        {
            this.titleTopResult = this.titleMatches.FirstOrDefault(x => x.Value == this.titleMatches.Values.Max());
            this.metaDescriptionTopResult = this.metaDescriptionMatches.FirstOrDefault(x => x.Value == this.metaDescriptionMatches.Values.Max());
            this.metaKeywordsTopResult = this.metaKeywordsMatches.FirstOrDefault(x => x.Value == this.metaKeywordsMatches.Values.Max());
        }

        public Categories GetDomainResult(HTML html, List<Keyword> domains)
        {
            var domain = html.GetTopLevelDomain();
            Categories cat = Categories.Unknown;

            foreach (var d in domains)
            {
                if (domain == d.word) { cat = d.cat; }
            }

            return cat;
        }

        public Categories GetURLResult(HTML html, List<Keyword> urlKeywords)
        {
            var url = html.url;
            Categories cat = Categories.Unknown;

            foreach (var w in urlKeywords)
            {
                if (url.Contains(w.word)) { cat = w.cat; }
            }

            return cat;
        }

        public Dictionary<Categories, int> GetMatchResults(string words, Data data)
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

                foreach (var keyword in data.keywords)
                {
                    if (w == keyword.word) { results[keyword.cat]++; }
                }

            }

            //match phrases
            foreach (var phrase in data.phrases)
            {
                var wordsLowerCase = words.ToLower();

                if (wordsLowerCase.Contains(phrase.word)) { results[phrase.cat]++; }
            }

            return results;
        }

        private List<string> Tokenize(string words)
        {
            List<string> wordList = new List<string>();
            List<string> tokenizedWords = new List<string>();

            if (string.IsNullOrEmpty(words)) { return wordList; }

            //split words by spaces
            wordList = words.Split().ToList();

            //get rid of ending punctuation
            foreach (var word in wordList)
            {
                if (word.EndsWith(","))
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

        public static bool IsCamelCase(string input)
        {
            Regex regex = new Regex("[A-Z]([A-Z0-9]*[a-z][a-z0-9]*[A-Z]|[a-z0-9]*[A-Z][A-Z0-9]*[a-z])[A-Za-z0-9]*");
            return regex.IsMatch(input);
        }

        public static string SplitCamelCase(string input)
        {
            var output = Regex.Replace(input, "([a-z](?=[A-Z0-9])|[A-Z](?=[A-Z][a-z]))", "$1 ");
            return output;
        }

        public void WriteTopResults()
        {
            //write results
            Console.WriteLine("title results: " + this.titleTopResult.Key.ToString() + " " + this.titleTopResult.Value.ToString());
            Console.WriteLine("meta description results: " + this.metaDescriptionTopResult.Key.ToString() + " " + this.metaDescriptionTopResult.Value.ToString());
            Console.WriteLine("meta keywords results: " + this.metaKeywordsTopResult.Key.ToString() + " " + this.metaKeywordsTopResult.Value.ToString());
            Console.WriteLine("domain result: " + this.domainResult.ToString());
            Console.WriteLine("url result: " + this.urlResult.ToString());
            Console.WriteLine("");
        }
    }
}

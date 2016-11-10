using System;
using System.Collections.Generic;
using System.Linq;
using static Enums;
using static Main.Data;
using System.Threading.Tasks;

namespace Main
{
    public class Result
    {
        public Dictionary<Categories, int> titleMatches { get; set; } = new Dictionary<Categories, int>();
        public Dictionary<Categories, int> metaDescriptionMatches { get; set; } = new Dictionary<Categories, int>();
        public Dictionary<Categories, int> metaKeywordsMatches { get; set; } = new Dictionary<Categories, int>();
        public Categories domainResult { get; set; } = Categories.Unknown;

        public Result(HTML html, Data data)
        {
            this.titleMatches = GetMatchResults(html.title, data);
            this.metaDescriptionMatches = GetMatchResults(html.metaDescription, data);
            this.metaKeywordsMatches = GetMatchResults(html.metaKeywords, data);
            this.domainResult = GetDomainResult(html, data.domains);
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

            //get rid of commas
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
    }
}

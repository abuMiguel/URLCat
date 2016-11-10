using System;
using System.Collections.Generic;
using static Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Data
    {
        public List<Keyword> keywords { get; set; } = new List<Keyword>();
        public List<Keyword> phrases { get; set; } = new List<Keyword>();
        public List<Keyword> domains { get; set; } = new List<Keyword>();

        public Data()
        {
            LoadKeywords();
            LoadPhrases();
            LoadDomains();
        }

        private void LoadKeywords()
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

        private void LoadPhrases()
        {
            phrases.Add(new Keyword("black friday", Categories.Shopping));
        }

        private void LoadDomains()
        {
            domains.Add(new Keyword("edu", Categories.Education));
            domains.Add(new Keyword("gov", Categories.Government));
            domains.Add(new Keyword("mil", Categories.Military));
            domains.Add(new Keyword("xxx", Categories.Adult));
        }
    }
}

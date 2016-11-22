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
        public List<Keyword> urlKeywords { get; set; } = new List<Keyword>();
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

            urlKeywords.Add(new Keyword(".ads.", Categories.Advertisements));
            urlKeywords.Add(new Keyword(".ad.", Categories.Advertisements));
            urlKeywords.Add(new Keyword("//ads", Categories.Advertisements));
            urlKeywords.Add(new Keyword("//ad.", Categories.Advertisements));
            urlKeywords.Add(new Keyword("//a.", Categories.Advertisements));
            urlKeywords.Add(new Keyword("//ad01", Categories.Advertisements));
            urlKeywords.Add(new Keyword("googleads", Categories.Advertisements));
            urlKeywords.Add(new Keyword("pagead", Categories.Advertisements));
            urlKeywords.Add(new Keyword("imgad", Categories.Advertisements));
            urlKeywords.Add(new Keyword("pubads", Categories.Advertisements));
            urlKeywords.Add(new Keyword("/ads/", Categories.Advertisements));
            urlKeywords.Add(new Keyword("medyanetads", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adserver", Categories.Advertisements));
            urlKeywords.Add(new Keyword("doubleclick.net", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adsniper", Categories.Advertisements));
            urlKeywords.Add(new Keyword("cpp-test.imp.mpx.mopub", Categories.Advertisements));
            urlKeywords.Add(new Keyword("ad_domain", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adnxs", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adsrvr", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adheight", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adwidth", Categories.Advertisements));
            urlKeywords.Add(new Keyword("showads", Categories.Advertisements));
            urlKeywords.Add(new Keyword("komoona", Categories.Advertisements));
            urlKeywords.Add(new Keyword(".advertising", Categories.Advertisements));
            urlKeywords.Add(new Keyword("uk-ads", Categories.Advertisements));
            urlKeywords.Add(new Keyword("adroll.com", Categories.Advertisements));
            urlKeywords.Add(new Keyword("zedo.com", Categories.Advertisements));
            urlKeywords.Add(new Keyword("bingads", Categories.Advertisements));

            urlKeywords.Add(new Keyword("cdn", Categories.ContentDeliveryNetworks));

            urlKeywords.Add(new Keyword("dropbox.com", Categories.PersonalNetworkStorageAndBackup));

            urlKeywords.Add(new Keyword(".mail.", Categories.GeneralEmail));
            urlKeywords.Add(new Keyword("email.", Categories.GeneralEmail));

            urlKeywords.Add(new Keyword("games", Categories.Games));

            urlKeywords.Add(new Keyword("stumbleupon", Categories.SocialNetworking));
            urlKeywords.Add(new Keyword("pinterest", Categories.SocialNetworking));

            urlKeywords.Add(new Keyword("facebook.com", Categories.SocialWebFacebook));
            urlKeywords.Add(new Keyword("linkedin.com", Categories.SocialWebLinkedIn));
            urlKeywords.Add(new Keyword("twitter.com", Categories.SocialWebTwitter));
            urlKeywords.Add(new Keyword("youtube.com", Categories.SocialWebYouTube));

            urlKeywords.Add(new Keyword("/images/", Categories.WebImages));
            urlKeywords.Add(new Keyword("/img.", Categories.WebImages));
            urlKeywords.Add(new Keyword("/images.", Categories.WebImages));
            urlKeywords.Add(new Keyword("/image.", Categories.WebImages));
            urlKeywords.Add(new Keyword(".jpg", Categories.WebImages));
            urlKeywords.Add(new Keyword(".png", Categories.WebImages));
            urlKeywords.Add(new Keyword(".gif", Categories.WebImages));

            //***************

            keywords.Add(new Keyword("stumbleupon", Categories.SocialNetworking));
            keywords.Add(new Keyword("pinterest", Categories.SocialNetworking));

            keywords.Add(new Keyword("translate", Categories.WebsiteTranslation));
            keywords.Add(new Keyword("translation", Categories.WebsiteTranslation));
            keywords.Add(new Keyword("translator", Categories.WebsiteTranslation));

            keywords.Add(new Keyword("facebook", Categories.SocialWebFacebook));
            keywords.Add(new Keyword("linkedin", Categories.SocialWebLinkedIn));
            keywords.Add(new Keyword("twitter", Categories.SocialWebTwitter));
            keywords.Add(new Keyword("youtube", Categories.SocialWebYouTube));

            keywords.Add(new Keyword("chat", Categories.WebChat));

            keywords.Add(new Keyword("business", Categories.BusinessAndEconomy));

            keywords.Add(new Keyword("alcohol", Categories.AlcoholAndTobacco));
            keywords.Add(new Keyword("tobacco", Categories.AlcoholAndTobacco));

            keywords.Add(new Keyword("email", Categories.GeneralEmail));
            keywords.Add(new Keyword("webmail", Categories.GeneralEmail));

            keywords.Add(new Keyword("wordpress", Categories.BlogsAndPersonalSites));

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

            keywords.Add(new Keyword("news", Categories.NewsAndMedia));

            keywords.Add(new Keyword("computer", Categories.InformationTechnology));
            keywords.Add(new Keyword("computers", Categories.InformationTechnology));
            keywords.Add(new Keyword("laptop", Categories.InformationTechnology));
            keywords.Add(new Keyword("laptops", Categories.InformationTechnology));
            keywords.Add(new Keyword("technology", Categories.InformationTechnology));
            keywords.Add(new Keyword("tech", Categories.InformationTechnology));
            keywords.Add(new Keyword("software", Categories.InformationTechnology));
            keywords.Add(new Keyword("phone", Categories.InformationTechnology));
            keywords.Add(new Keyword("smartphone", Categories.InformationTechnology));
            keywords.Add(new Keyword("mobile", Categories.InformationTechnology));
            keywords.Add(new Keyword("app", Categories.InformationTechnology));

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

            keywords.Add(new Keyword("money", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("finance", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("finances", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("financial", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("stock", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("stocks", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("mortgage", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("loans", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("refinance", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("credit", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("investment", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("insurance", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("bank", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("banks", Categories.FinancialDataAndServices));

            keywords.Add(new Keyword("blog", Categories.BlogsAndPersonalSites));
            keywords.Add(new Keyword("blogs", Categories.BlogsAndPersonalSites));
            keywords.Add(new Keyword("vlog", Categories.BlogsAndPersonalSites));
            keywords.Add(new Keyword("blogger", Categories.BlogsAndPersonalSites));
            keywords.Add(new Keyword("blogging", Categories.BlogsAndPersonalSites));

            keywords.Add(new Keyword("politics", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("republican", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("democrat", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("vote", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("voting", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("political", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("politician", Categories.PoliticalOrganizations));

            keywords.Add(new Keyword("search", Categories.SearchEnginesAndPortals));
            keywords.Add(new Keyword("searching", Categories.SearchEnginesAndPortals));

            //keywords.Add(new Keyword("travel", Categories.Travel));

            //keywords.Add(new Keyword("fashion", Categories.FashionAndBeauty));
            //keywords.Add(new Keyword("hair", Categories.FashionAndBeauty));

            keywords.Add(new Keyword("shopping", Categories.Shopping));
            keywords.Add(new Keyword("deals", Categories.Shopping));
            keywords.Add(new Keyword("savings", Categories.Shopping));

            keywords.Add(new Keyword("government", Categories.Government));
            keywords.Add(new Keyword("agency", Categories.Government));
            keywords.Add(new Keyword("agencies", Categories.Government));

            keywords.Add(new Keyword("porn", Categories.AdultContent));
            keywords.Add(new Keyword("xxx", Categories.AdultContent));
            keywords.Add(new Keyword("sex", Categories.AdultContent));
            keywords.Add(new Keyword("pussy", Categories.AdultContent));
            keywords.Add(new Keyword("porno", Categories.AdultContent));
            keywords.Add(new Keyword("pornstar", Categories.AdultContent));
            keywords.Add(new Keyword("pornstars", Categories.AdultContent));
            keywords.Add(new Keyword("fuck", Categories.AdultContent));
            keywords.Add(new Keyword("pornvideos", Categories.AdultContent));
            keywords.Add(new Keyword("pornvideo", Categories.AdultContent));
        }

        private void LoadPhrases()
        {
            phrases.Add(new Keyword("black friday", Categories.Shopping));
        }

        private void LoadDomains()
        {
            domains.Add(new Keyword("edu", Categories.EducationalInstitutions));
            domains.Add(new Keyword("gov", Categories.Government));
            domains.Add(new Keyword("mil", Categories.Military));
            domains.Add(new Keyword("xxx", Categories.AdultContent));
        }
    }
}

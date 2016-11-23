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
            urlKeywords.Add(new Keyword("abortion", Categories.Abortion));

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
            urlKeywords.Add(new Keyword("puzzles", Categories.Games));
            urlKeywords.Add(new Keyword("puzzle", Categories.Games));

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

            keywords.Add(new Keyword("abortion", Categories.Abortion));
            keywords.Add(new Keyword("pro-life", Categories.Abortion));
            keywords.Add(new Keyword("pro-choice", Categories.Abortion));

            keywords.Add(new Keyword("download", Categories.ApplicationAndSoftwareDownload));

            keywords.Add(new Keyword("freeware", Categories.FreewareAndSoftwareDownload));

            keywords.Add(new Keyword("cdn", Categories.ContentDeliveryNetworks));

            keywords.Add(new Keyword("culture", Categories.CulturalInstitutions));
            keywords.Add(new Keyword("cultural", Categories.CulturalInstitutions));

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
            keywords.Add(new Keyword("economy", Categories.BusinessAndEconomy));
            keywords.Add(new Keyword("economics", Categories.BusinessAndEconomy));
            keywords.Add(new Keyword("businesses", Categories.BusinessAndEconomy));

            keywords.Add(new Keyword("alcohol", Categories.AlcoholAndTobacco));
            keywords.Add(new Keyword("tobacco", Categories.AlcoholAndTobacco));

            keywords.Add(new Keyword("email", Categories.GeneralEmail));
            keywords.Add(new Keyword("webmail", Categories.GeneralEmail));
            keywords.Add(new Keyword("e-mail", Categories.GeneralEmail));

            keywords.Add(new Keyword("wordpress", Categories.BlogsAndPersonalSites));
            keywords.Add(new Keyword("blogger", Categories.BlogsAndPersonalSites));

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
            keywords.Add(new Keyword("fishing", Categories.Sports));
            keywords.Add(new Keyword("volleyball", Categories.Sports));
            keywords.Add(new Keyword("running", Categories.Sports));
            keywords.Add(new Keyword("jogging", Categories.Sports));
            keywords.Add(new Keyword("cycling", Categories.Sports));
            keywords.Add(new Keyword("bicycle", Categories.Sports));
            keywords.Add(new Keyword("racing", Categories.Sports));
            keywords.Add(new Keyword("nascar", Categories.Sports));
            keywords.Add(new Keyword("handball", Categories.Sports));
            keywords.Add(new Keyword("sailing", Categories.Sports));
            keywords.Add(new Keyword("rugby", Categories.Sports));
            keywords.Add(new Keyword("surfing", Categories.Sports));
            keywords.Add(new Keyword("swimming", Categories.Sports));
            keywords.Add(new Keyword("taekwondo", Categories.Sports));
            keywords.Add(new Keyword("skiing", Categories.Sports));
            keywords.Add(new Keyword("snowboarding", Categories.Sports));
            keywords.Add(new Keyword("boxing", Categories.Sports));
            keywords.Add(new Keyword("ufc", Categories.Sports));
            keywords.Add(new Keyword("mma", Categories.Sports));
            keywords.Add(new Keyword("lacrosse", Categories.Sports));
            keywords.Add(new Keyword("judo", Categories.Sports));
            keywords.Add(new Keyword("raquetball", Categories.Sports));

            keywords.Add(new Keyword("hunting", Categories.SportHuntingAndGunClubs));
            keywords.Add(new Keyword("shotgun", Categories.SportHuntingAndGunClubs));
            keywords.Add(new Keyword("guns", Categories.SportHuntingAndGunClubs));
            keywords.Add(new Keyword("hunt", Categories.SportHuntingAndGunClubs));
            keywords.Add(new Keyword("hunter", Categories.SportHuntingAndGunClubs));
            keywords.Add(new Keyword("skeet", Categories.SportHuntingAndGunClubs));

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
            keywords.Add(new Keyword(".net", Categories.InformationTechnology));
            keywords.Add(new Keyword("powershell", Categories.InformationTechnology));
            keywords.Add(new Keyword("linux", Categories.InformationTechnology));
            keywords.Add(new Keyword("microsoft", Categories.InformationTechnology));

            keywords.Add(new Keyword("education", Categories.Education));
            keywords.Add(new Keyword("educational", Categories.Education));

            keywords.Add(new Keyword("celebrity", Categories.Entertainment));
            keywords.Add(new Keyword("celebrities", Categories.Entertainment));
            keywords.Add(new Keyword("entertainment", Categories.Entertainment));
            keywords.Add(new Keyword("games", Categories.Entertainment));
            keywords.Add(new Keyword("game", Categories.Entertainment));
            keywords.Add(new Keyword("television", Categories.Entertainment));
            keywords.Add(new Keyword("tv", Categories.Entertainment));
            keywords.Add(new Keyword("shows", Categories.Entertainment));
            keywords.Add(new Keyword("episodes", Categories.Entertainment));
            keywords.Add(new Keyword("watch", Categories.Entertainment));
            keywords.Add(new Keyword("music", Categories.Entertainment));
            keywords.Add(new Keyword("songs", Categories.Entertainment));
            keywords.Add(new Keyword("actor", Categories.Entertainment));
            keywords.Add(new Keyword("actress", Categories.Entertainment));
            keywords.Add(new Keyword("circus", Categories.Entertainment));
            keywords.Add(new Keyword("theater", Categories.Entertainment));
            keywords.Add(new Keyword("theatre", Categories.Entertainment));

            keywords.Add(new Keyword("video", Categories.EntertainmentVideo));

            keywords.Add(new Keyword("mp3", Categories.MP3AndAudioDownloadServices));

            keywords.Add(new Keyword("gambling", Categories.Gambling));
            keywords.Add(new Keyword("gamble", Categories.Gambling));
            keywords.Add(new Keyword("lottery", Categories.Gambling));
            keywords.Add(new Keyword("lotto", Categories.Gambling));
            keywords.Add(new Keyword("poker", Categories.Gambling));
            keywords.Add(new Keyword("casino", Categories.Gambling));

            keywords.Add(new Keyword("gay", Categories.GayOrLesbianOrBisexualInterest));
            keywords.Add(new Keyword("lesbian", Categories.GayOrLesbianOrBisexualInterest));
            keywords.Add(new Keyword("gays", Categories.GayOrLesbianOrBisexualInterest));
            keywords.Add(new Keyword("lesbians", Categories.GayOrLesbianOrBisexualInterest));
            keywords.Add(new Keyword("bisexual", Categories.GayOrLesbianOrBisexualInterest));
            keywords.Add(new Keyword("homosexual", Categories.GayOrLesbianOrBisexualInterest));
            keywords.Add(new Keyword("lgbt", Categories.GayOrLesbianOrBisexualInterest));

            keywords.Add(new Keyword("health", Categories.Health));
            keywords.Add(new Keyword("healthy", Categories.Health));
            keywords.Add(new Keyword("exercise", Categories.Health));
            keywords.Add(new Keyword("yoga", Categories.Health));
            keywords.Add(new Keyword("gymn", Categories.Health));
            keywords.Add(new Keyword("workout", Categories.Health));
            keywords.Add(new Keyword("bodybuilding", Categories.Health));

            keywords.Add(new Keyword("nutrition", Categories.Nutrition));
            keywords.Add(new Keyword("supplements", Categories.Nutrition));
            keywords.Add(new Keyword("vitamins", Categories.Nutrition));

            keywords.Add(new Keyword("hobby", Categories.Hobbies));
            keywords.Add(new Keyword("hobbies", Categories.Hobbies));
            keywords.Add(new Keyword("cosplay", Categories.Hobbies));
            keywords.Add(new Keyword("coloring", Categories.Hobbies));
            keywords.Add(new Keyword("couponing", Categories.Hobbies));
            keywords.Add(new Keyword("dance", Categories.Hobbies));
            keywords.Add(new Keyword("dancing", Categories.Hobbies));
            keywords.Add(new Keyword("drawing", Categories.Hobbies));
            keywords.Add(new Keyword("art", Categories.Hobbies));
            keywords.Add(new Keyword("diy", Categories.Hobbies));
            keywords.Add(new Keyword("embroidery", Categories.Hobbies));
            keywords.Add(new Keyword("crochet", Categories.Hobbies));
            keywords.Add(new Keyword("knitting", Categories.Hobbies));
            keywords.Add(new Keyword("genealogy", Categories.Hobbies));
            keywords.Add(new Keyword("glassblowing", Categories.Hobbies));
            keywords.Add(new Keyword("homebrewing", Categories.Hobbies));
            keywords.Add(new Keyword("iceskating", Categories.Hobbies));
            keywords.Add(new Keyword("juggling", Categories.Hobbies));
            keywords.Add(new Keyword("lapidary", Categories.Hobbies));
            keywords.Add(new Keyword("painting", Categories.Hobbies));
            keywords.Add(new Keyword("origami", Categories.Hobbies));
            keywords.Add(new Keyword("pottery", Categories.Hobbies));
            keywords.Add(new Keyword("quilting", Categories.Hobbies));
            keywords.Add(new Keyword("reading", Categories.Hobbies));
            keywords.Add(new Keyword("scrapbooking", Categories.Hobbies));
            keywords.Add(new Keyword("sewing", Categories.Hobbies));
            keywords.Add(new Keyword("sculpting", Categories.Hobbies));
            keywords.Add(new Keyword("singing", Categories.Hobbies));
            keywords.Add(new Keyword("sketching", Categories.Hobbies));
            keywords.Add(new Keyword("beekeeping", Categories.Hobbies));
            keywords.Add(new Keyword("camping", Categories.Hobbies));
            keywords.Add(new Keyword("gardening", Categories.Hobbies));
            keywords.Add(new Keyword("geocaching", Categories.Hobbies));
            keywords.Add(new Keyword("larping", Categories.Hobbies));
            keywords.Add(new Keyword("rappelling", Categories.Hobbies));
            keywords.Add(new Keyword("scouting", Categories.Hobbies));
            keywords.Add(new Keyword("collecting", Categories.Hobbies));
            keywords.Add(new Keyword("cheerleading", Categories.Hobbies));
            keywords.Add(new Keyword("billiards", Categories.Hobbies));
            keywords.Add(new Keyword("pool", Categories.Hobbies));
            keywords.Add(new Keyword("bowling", Categories.Hobbies));
            keywords.Add(new Keyword("photography", Categories.Hobbies));
            keywords.Add(new Keyword("hobbyz", Categories.Hobbies));


            keywords.Add(new Keyword("army", Categories.Military));
            keywords.Add(new Keyword("marines", Categories.Military));
            keywords.Add(new Keyword("navy", Categories.Military));
            keywords.Add(new Keyword("marine", Categories.Military));
            keywords.Add(new Keyword("sailor", Categories.Military));
            keywords.Add(new Keyword("airforce", Categories.Military));
            keywords.Add(new Keyword("soldier", Categories.Military));
            keywords.Add(new Keyword("soldiers", Categories.Military));

            keywords.Add(new Keyword("forum", Categories.MessageBoardsAndForums));
            keywords.Add(new Keyword("forums", Categories.MessageBoardsAndForums));


            keywords.Add(new Keyword("restaurant", Categories.RestaurantsAndDining));
            keywords.Add(new Keyword("fast-food", Categories.RestaurantsAndDining));
            keywords.Add(new Keyword("dining", Categories.RestaurantsAndDining));
            keywords.Add(new Keyword("food", Categories.RestaurantsAndDining));
            keywords.Add(new Keyword("pizza", Categories.RestaurantsAndDining));
            keywords.Add(new Keyword("burger", Categories.RestaurantsAndDining));
            keywords.Add(new Keyword("coffee", Categories.RestaurantsAndDining));

            keywords.Add(new Keyword("money", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("finance", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("finances", Categories.FinancialDataAndServices));
            keywords.Add(new Keyword("financial", Categories.FinancialDataAndServices));
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
            keywords.Add(new Keyword("wordpress", Categories.BlogsAndPersonalSites));

            keywords.Add(new Keyword("politics", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("republican", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("democrat", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("democratic", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("vote", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("voter", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("voting", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("political", Categories.PoliticalOrganizations));
            keywords.Add(new Keyword("politician", Categories.PoliticalOrganizations));

            keywords.Add(new Keyword("marijuana", Categories.Marijuana));
            keywords.Add(new Keyword("hemp", Categories.Marijuana));

            keywords.Add(new Keyword("jobs", Categories.JobSearch));
            keywords.Add(new Keyword("job", Categories.JobSearch));
            keywords.Add(new Keyword("career", Categories.JobSearch));
            keywords.Add(new Keyword("careers", Categories.JobSearch));
            keywords.Add(new Keyword("employment", Categories.JobSearch));
            keywords.Add(new Keyword("work", Categories.JobSearch));
            keywords.Add(new Keyword("hiring", Categories.JobSearch));
            keywords.Add(new Keyword("recruiting", Categories.JobSearch));


            keywords.Add(new Keyword("search", Categories.SearchEnginesAndPortals));
            keywords.Add(new Keyword("searching", Categories.SearchEnginesAndPortals));

            //keywords.Add(new Keyword("travel", Categories.Travel));

            //keywords.Add(new Keyword("fashion", Categories.FashionAndBeauty));
            //keywords.Add(new Keyword("hair", Categories.FashionAndBeauty));

            keywords.Add(new Keyword("bikini", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("bikinis", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("swimsuit", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("swimsuits", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("gstring", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("gstrings", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("lingerie", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("thong", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("thongs", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("bras", Categories.LingerieAndSwimsuit));
            keywords.Add(new Keyword("panties", Categories.LingerieAndSwimsuit));


            keywords.Add(new Keyword("shopping", Categories.Shopping));
            keywords.Add(new Keyword("deals", Categories.Shopping));
            keywords.Add(new Keyword("savings", Categories.Shopping));
            keywords.Add(new Keyword("shop", Categories.Shopping));
            keywords.Add(new Keyword("buy", Categories.Shopping));
            keywords.Add(new Keyword("coupon", Categories.Shopping));
            keywords.Add(new Keyword("jewelry", Categories.Shopping));

            keywords.Add(new Keyword("cpanel", Categories.WebHosting));
            keywords.Add(new Keyword("freehosting", Categories.WebHosting));
            keywords.Add(new Keyword("webhosting", Categories.WebHosting));

            keywords.Add(new Keyword("government", Categories.Government));
            keywords.Add(new Keyword("agency", Categories.Government));
            keywords.Add(new Keyword("agencies", Categories.Government));

            keywords.Add(new Keyword("gun", Categories.Weapons));
            keywords.Add(new Keyword("guns", Categories.Weapons));
            keywords.Add(new Keyword("weapon", Categories.Weapons));
            keywords.Add(new Keyword("weapons", Categories.Weapons));
            keywords.Add(new Keyword("rifle", Categories.Weapons));
            keywords.Add(new Keyword("shotgun", Categories.Weapons));
            keywords.Add(new Keyword("pistol", Categories.Weapons));
            keywords.Add(new Keyword("9mm", Categories.Weapons));
            keywords.Add(new Keyword("bullet", Categories.Weapons));
            keywords.Add(new Keyword("ammo", Categories.Weapons));
            keywords.Add(new Keyword("ammunition", Categories.Weapons));

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

            phrases.Add(new Keyword("lose weight", Categories.Health));
            phrases.Add(new Keyword("weight loss", Categories.Health));
            phrases.Add(new Keyword("weight lifting", Categories.Health));
            phrases.Add(new Keyword("weight-lifting", Categories.Health));

            phrases.Add(new Keyword("3d printing", Categories.InformationTechnology));

            phrases.Add(new Keyword("download music", Categories.MP3AndAudioDownloadServices));
            phrases.Add(new Keyword("download songs", Categories.MP3AndAudioDownloadServices));
            phrases.Add(new Keyword("download mp3s", Categories.MP3AndAudioDownloadServices));
            phrases.Add(new Keyword("download mp3", Categories.MP3AndAudioDownloadServices));

            phrases.Add(new Keyword("do it yourself", Categories.Hobbies));
            phrases.Add(new Keyword("ice skating", Categories.Hobbies));
            phrases.Add(new Keyword("magic show", Categories.Hobbies));
            phrases.Add(new Keyword("table tennis", Categories.Hobbies));
            phrases.Add(new Keyword("ping pong", Categories.Hobbies));
            phrases.Add(new Keyword("wood carving", Categories.Hobbies));
            phrases.Add(new Keyword("wood working", Categories.Hobbies));
            phrases.Add(new Keyword("bee keeping", Categories.Hobbies));
            phrases.Add(new Keyword("base jumping", Categories.Hobbies));
            phrases.Add(new Keyword("bird watching", Categories.Hobbies));
            keywords.Add(new Keyword("radio control", Categories.Hobbies));
            keywords.Add(new Keyword("remote control", Categories.Hobbies));
            keywords.Add(new Keyword("rc cars", Categories.Hobbies));
            keywords.Add(new Keyword("rc planes", Categories.Hobbies));
            keywords.Add(new Keyword("rc helicopters", Categories.Hobbies));
            keywords.Add(new Keyword("rc car", Categories.Hobbies));
            keywords.Add(new Keyword("rc parts", Categories.Hobbies));


            phrases.Add(new Keyword("horseback riding", Categories.Sports));
            phrases.Add(new Keyword("rock climbing", Categories.Sports));
            phrases.Add(new Keyword("field hockey", Categories.Sports));
            phrases.Add(new Keyword("figure skating", Categories.Sports));

            phrases.Add(new Keyword("stand-up comedy", Categories.Entertainment));

            phrases.Add(new Keyword("web hosting", Categories.WebHosting));
            phrases.Add(new Keyword("web host", Categories.WebHosting));
            phrases.Add(new Keyword("website hosting", Categories.WebHosting));

            phrases.Add(new Keyword("web analytics", Categories.WebAnalytics));

            phrases.Add(new Keyword("marine corps", Categories.Military));

            phrases.Add(new Keyword("message board", Categories.MessageBoardsAndForums));
            phrases.Add(new Keyword("message boards", Categories.MessageBoardsAndForums));

            phrases.Add(new Keyword("job search", Categories.JobSearch));


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

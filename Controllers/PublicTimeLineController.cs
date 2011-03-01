using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TwitterNewsPaper001.Controllers
{
    public class PublicTimeLineController
    {

        public Dictionary<string, string> tweets = new Dictionary<string, string>();
        public Dictionary<string, string> sportsTweets = new Dictionary<string, string>();
        public Dictionary<string, string> miscTweets = new Dictionary<string, string>();
        public Dictionary<string, string> politicalTweets = new Dictionary<string, string>();
        public Dictionary<string, string> musicTweets = new Dictionary<string, string>();
        public Dictionary<string, string> foodTweets = new Dictionary<string, string>();
        public Dictionary<string, string> relationshipTweets = new Dictionary<string, string>();
        public Dictionary<string, string> linkTweets = new Dictionary<string, string>();
        public Dictionary<string, string> weatherTweets = new Dictionary<string, string>();
        public Dictionary<string, string> celebrityTweets = new Dictionary<string, string>();
        public Dictionary<string, string> technologyTweets = new Dictionary<string, string>();
        public Dictionary<string, string> healthTweets = new Dictionary<string, string>();
        public Dictionary<string, string> starcraftTweets = new Dictionary<string, string>();
        public Dictionary<string, string> occasionTweets = new Dictionary<string, string>();
        public Dictionary<string, string> partyTweets = new Dictionary<string, string>();

        public Dictionary<string, string> sportsFilter = new Dictionary<string, string>();
        public Dictionary<string, string> musicFilter = new Dictionary<string, string>();
        public Dictionary<string, string> relationshipFilter = new Dictionary<string, string>();
        public Dictionary<string, string> weatherFilter = new Dictionary<string, string>();
        public Dictionary<string, string> technologyFilter = new Dictionary<string, string>();
        public Dictionary<string, string> politicalFilter = new Dictionary<string, string>();
        public Dictionary<string, string> celebrityFilter = new Dictionary<string, string>();
        public Dictionary<string, string> foodFilter = new Dictionary<string, string>();
        public Dictionary<string, string> starcraftFilter = new Dictionary<string, string>();
        public Dictionary<string, string> occasionFilter = new Dictionary<string, string>();
        public Dictionary<string, string> partyFilter = new Dictionary<string, string>();

        public string allcelebrityTweets = "";

        public void InitializeFilters()
        {
            sportsFilter.Add("lebron", "basket-ball");
            sportsFilter.Add("Kobe", "basket-ball");
            sportsFilter.Add("basket", "basket-ball");
            sportsFilter.Add("basketball", "basket-ball");
            sportsFilter.Add("basket-ball", "basket-ball");
            sportsFilter.Add("three-pointer", "basket-ball");
            sportsFilter.Add("threepointer", "basket-ball");
            sportsFilter.Add("dunk", "basket-ball");
            sportsFilter.Add("dunked", "basket-ball");
            sportsFilter.Add("pass", "basket-ball");
            sportsFilter.Add("nba", "basket-ball");
            sportsFilter.Add("#nba", "basket-ball");
            sportsFilter.Add("raptors", "basket-ball");
            sportsFilter.Add("clippers", "basket-ball");
            sportsFilter.Add("lakers", "basket-ball");
            sportsFilter.Add("celtics", "basket-ball");
            sportsFilter.Add("thunder", "basket-ball");
            sportsFilter.Add("dribble", "basket-ball");
            sportsFilter.Add("post", "basket-ball");
            sportsFilter.Add("boxed-out", "basket-ball");
            sportsFilter.Add("game", "basket-ball");
            sportsFilter.Add("#thegame", "basket-ball");
            sportsFilter.Add("race", "basket-ball");
            sportsFilter.Add("jump", "basket-ball");

            musicFilter.Add("cd", "music");
            musicFilter.Add("demo", "music");
            musicFilter.Add("band", "music");
            musicFilter.Add("concert", "music");
            musicFilter.Add("video", "music");
            musicFilter.Add("music", "music");
            musicFilter.Add("instrument", "music");
            musicFilter.Add("guitar", "music");
            musicFilter.Add("bass", "music");
            musicFilter.Add("drum", "music");
            musicFilter.Add("drummer", "music");
            musicFilter.Add("chord", "music");
            musicFilter.Add("note", "music");
            musicFilter.Add("voice", "music");
            musicFilter.Add("sing", "music");
            musicFilter.Add("singing", "music");
            musicFilter.Add("song", "music");
            musicFilter.Add("radio", "music");
            musicFilter.Add("soundtrack", "music");

            relationshipFilter.Add("love", "relationship");
            relationshipFilter.Add("kiss", "relationship");
            relationshipFilter.Add("kissing", "relationship");
            relationshipFilter.Add("kissed", "relationship");
            relationshipFilter.Add("touch", "relationship");
            relationshipFilter.Add("date", "relationship");
            relationshipFilter.Add("guy", "relationship");
            relationshipFilter.Add("bf", "relationship");
            relationshipFilter.Add("gf", "relationship");
            relationshipFilter.Add("girl", "relationship");
            relationshipFilter.Add("man", "relationship");
            relationshipFilter.Add("men", "relationship");
            relationshipFilter.Add("woman", "relationship");
            relationshipFilter.Add("women", "relationship");
            relationshipFilter.Add("girlfriend", "relationship");
            relationshipFilter.Add("hot", "relationship");
            relationshipFilter.Add("boyfriend", "relationship");
            relationshipFilter.Add("good looking", "relationship");
            relationshipFilter.Add("sweet", "relationship");
            relationshipFilter.Add("soulmate", "relationship");
            relationshipFilter.Add("partner", "relationship");
            relationshipFilter.Add("hug", "relationship");
            relationshipFilter.Add("loved", "relationship");
            relationshipFilter.Add("care", "relationship");
            relationshipFilter.Add("miss", "relationship");
            relationshipFilter.Add("missed", "relationship");
            relationshipFilter.Add("<3", "relationship");
            relationshipFilter.Add("s2", "relationship");
            relationshipFilter.Add("< 3", "relationship");
            relationshipFilter.Add("heart", "relationship");
            relationshipFilter.Add("lips", "relationship");
            relationshipFilter.Add("sex", "relationship");
            relationshipFilter.Add("horny", "relationship");
            relationshipFilter.Add("sexy", "relationship");
            relationshipFilter.Add("flirt", "relationship");
            relationshipFilter.Add("make", "relationship");
            relationshipFilter.Add("out", "relationship");
            relationshipFilter.Add("makeout", "relationship");
            relationshipFilter.Add("make-out", "relationship");

            weatherFilter.Add("snow", "weather");
            weatherFilter.Add("rain", "weather");
            weatherFilter.Add("wind", "weather");
            weatherFilter.Add("tornado", "weather");
            weatherFilter.Add("hurricane", "weather");
            weatherFilter.Add("smog", "weather");
            weatherFilter.Add("heat", "weather");
            weatherFilter.Add("cold", "weather");
            weatherFilter.Add("freezing", "weather");
            weatherFilter.Add("melting", "weather");
            weatherFilter.Add("ice", "weather");
            weatherFilter.Add("slush", "weather");
            weatherFilter.Add("weather", "weather");
            weatherFilter.Add("conditions", "weather");
            weatherFilter.Add("humidity", "weather");
            weatherFilter.Add("humid", "weather");
            weatherFilter.Add("degrees", "weather");
            weatherFilter.Add("farenheit", "weather");
            weatherFilter.Add("warning", "weather");
            weatherFilter.Add("temperature", "weather");

            technologyFilter.Add("laptop", "technology");
            technologyFilter.Add("game", "technology");
            technologyFilter.Add("computer", "technology");
            technologyFilter.Add("disc", "technology");
            technologyFilter.Add("driver", "technology");
            technologyFilter.Add("battery", "technology");
            technologyFilter.Add("keyboard", "technology");
            technologyFilter.Add("mouse", "technology");
            technologyFilter.Add("earphone", "technology");
            technologyFilter.Add("intel", "technology");
            technologyFilter.Add("ati", "technology");
            technologyFilter.Add("nvidia", "technology");
            technologyFilter.Add("apple", "technology");
            technologyFilter.Add("mac", "technology");
            technologyFilter.Add("iphone", "technology");
            technologyFilter.Add("phone", "technology");
            technologyFilter.Add("internet", "technology");
            technologyFilter.Add("network", "technology");
            technologyFilter.Add("led", "technology");
            technologyFilter.Add("lcd", "technology");
            technologyFilter.Add("server", "technology");

            celebrityFilter.Add("awards", "celebrity");
            celebrityFilter.Add("award", "celebrity");
            celebrityFilter.Add("grammy", "celebrity");
            celebrityFilter.Add("grammys", "celebrity");
            celebrityFilter.Add("best", "celebrity");
            celebrityFilter.Add("actor", "celebrity");
            celebrityFilter.Add("actress", "celebrity");
            celebrityFilter.Add("director", "celebrity");
            celebrityFilter.Add("movie", "celebrity");
            celebrityFilter.Add("film", "celebrity");
            celebrityFilter.Add("motion", "celebrity");
            celebrityFilter.Add("picture", "celebrity");
            celebrityFilter.Add("celebrity", "celebrity");
            celebrityFilter.Add("fame", "celebrity");
            celebrityFilter.Add("idol", "celebrity");
            celebrityFilter.Add("natalie", "celebrity");
            celebrityFilter.Add("portman", "celebrity");
            celebrityFilter.Add("eminem", "celebrity");
            celebrityFilter.Add("gaga", "celebrity");
            celebrityFilter.Add("lady", "celebrity");
            celebrityFilter.Add("rhianna", "celebrity");
            celebrityFilter.Add("chris", "celebrity");
            celebrityFilter.Add("justin", "celebrity");
            celebrityFilter.Add("bieber", "celebrity");
            celebrityFilter.Add("never", "celebrity");
            celebrityFilter.Add("taylor", "celebrity");
            celebrityFilter.Add("swift", "celebrity");
            celebrityFilter.Add("kids", "celebrity");
            celebrityFilter.Add("dress", "celebrity");

            foodFilter.Add("dinner", "food");
            foodFilter.Add("lunch", "food");
            foodFilter.Add("breakfast", "food");
            foodFilter.Add("bake", "food");
            foodFilter.Add("oven", "food");
            foodFilter.Add("ate", "food");
            foodFilter.Add("restaurant", "food");
            foodFilter.Add("delicious", "food");
            foodFilter.Add("tasty", "food");
            foodFilter.Add("meal", "food");
            foodFilter.Add("hungry", "food");
            foodFilter.Add("coffee", "food");
            foodFilter.Add("timmies", "food");
            foodFilter.Add("dougnut", "food");
            foodFilter.Add("timbits", "food");
            foodFilter.Add("fork", "food");
            foodFilter.Add("ketchup", "food");
            foodFilter.Add("soda", "food");
            foodFilter.Add("alcohol", "food");
            foodFilter.Add("wine", "food");
            foodFilter.Add("vodka", "food");
            foodFilter.Add("tequila", "food");
            foodFilter.Add("rum", "food");
            foodFilter.Add("cheese", "food");
            foodFilter.Add("burger", "food");
            foodFilter.Add("egg", "food");
            foodFilter.Add("juice", "food");
            foodFilter.Add("fries", "food");
            foodFilter.Add("lettuce", "food");
            foodFilter.Add("tomatoe", "food");
            foodFilter.Add("onion", "food");
            foodFilter.Add("ginger", "food");
            foodFilter.Add("soup", "food");
            foodFilter.Add("noodle", "food");
            foodFilter.Add("pasta", "food");
            foodFilter.Add("fish", "food");
            foodFilter.Add("lemon", "food");
            foodFilter.Add("lime", "food");
            foodFilter.Add("spice", "food");
            foodFilter.Add("pepper", "food");
            foodFilter.Add("vinegar", "food");
            foodFilter.Add("olive", "food");
            foodFilter.Add("taste", "food");
            foodFilter.Add("tasting", "food");
            foodFilter.Add("tastes", "food");
            foodFilter.Add("aroma", "food");
            foodFilter.Add("smell", "food");
            foodFilter.Add("drool", "food");
            foodFilter.Add("watering", "food");
            foodFilter.Add("mouth", "food");
            foodFilter.Add("bistro", "food");
            foodFilter.Add("desert", "food");
            foodFilter.Add("dessert", "food");
            foodFilter.Add("cream", "food");
            foodFilter.Add("whipped", "food");
            foodFilter.Add("cherry", "food");
            foodFilter.Add("ice", "food");
            foodFilter.Add("chilled", "food");
            foodFilter.Add("marinate", "food");
            foodFilter.Add("barbeque", "food");
            foodFilter.Add("singe", "food");
            foodFilter.Add("stir", "food");
            foodFilter.Add("fry", "food");
            foodFilter.Add("gut", "food");
            foodFilter.Add("skin", "food");
            foodFilter.Add("boil", "food");
            foodFilter.Add("heat", "food");
            foodFilter.Add("simmer", "food");
            foodFilter.Add("seating", "food");
            foodFilter.Add("atmosphere", "food");
            foodFilter.Add("candle", "food");
            foodFilter.Add("waiter", "food");
            foodFilter.Add("service", "food");
            foodFilter.Add("chef", "food");
            foodFilter.Add("cook", "food");
            foodFilter.Add("cooked", "food");
            foodFilter.Add("choke", "food");
            foodFilter.Add("meat", "food");
            foodFilter.Add("juices", "food");
            foodFilter.Add("waitress", "food");
            foodFilter.Add("table", "food");
            foodFilter.Add("reservation", "food");
            foodFilter.Add("dining", "food");
            foodFilter.Add("stuffed", "food");
            foodFilter.Add("pad", "food");
            foodFilter.Add("thai", "food");
            foodFilter.Add("pho", "food");
            foodFilter.Add("mcdonalds", "food");
            foodFilter.Add("burgerking", "food");
            foodFilter.Add("kfc", "food");
            foodFilter.Add("wendys", "food");
            foodFilter.Add("donalds", "food");
            foodFilter.Add("mcgangbang", "food");
            foodFilter.Add("whopper", "food");
            foodFilter.Add("bigmac", "food");
            foodFilter.Add("mario", "food");
            foodFilter.Add("italian", "food");
            foodFilter.Add("minestrom", "food");
            foodFilter.Add("kraft", "food");
            foodFilter.Add("canned", "food");
            foodFilter.Add("instant", "food");
            foodFilter.Add("shrimp", "food");
            foodFilter.Add("oyster", "food");
            foodFilter.Add("tip", "food");
            foodFilter.Add("menu", "food");
            foodFilter.Add("special", "food");
            foodFilter.Add("specials", "food");
            foodFilter.Add("deal", "food");
            foodFilter.Add("deals", "food");
            foodFilter.Add("sandwhich", "food");
            /*foodFilter.Add("i", "food");
            foodFilter.Add("you", "food");
            foodFilter.Add("love", "food");
            foodFilter.Add("miss", "food");
            foodFilter.Add("obama", "food");
            foodFilter.Add("no", "food");
            foodFilter.Add("hate", "food");
            foodFilter.Add("can", "food");
            foodFilter.Add("cant", "food");
            foodFilter.Add("always", "food");
            foodFilter.Add("did", "food");
            foodFilter.Add("just", "food");
            foodFilter.Add("will", "food");
            foodFilter.Add("not", "food");
            foodFilter.Add("why", "food");
            foodFilter.Add("what", "food");
            foodFilter.Add("when", "food");
            foodFilter.Add("where", "food");
            foodFilter.Add("who", "food");
            foodFilter.Add("winter", "food");*/

            partyFilter.Add("vodka", "food");
            partyFilter.Add("tequila", "food");
            partyFilter.Add("rum", "food");
            partyFilter.Add("screwdriver", "food");
            partyFilter.Add("wine", "food");
            partyFilter.Add("shot", "food");
            partyFilter.Add("shots", "food");
            partyFilter.Add("chug", "food");
            partyFilter.Add("chugged", "food");
            partyFilter.Add("beer", "food");
            partyFilter.Add("budweiser", "food");
            partyFilter.Add("bottle", "food");
            partyFilter.Add("canadian", "food");
            partyFilter.Add("heineiken", "food");
            partyFilter.Add("drunk", "food");
            partyFilter.Add("drunkard", "food");
            partyFilter.Add("tipsy", "food");
            partyFilter.Add("hurl", "food");
            partyFilter.Add("hurled", "food");
            partyFilter.Add("toilet", "food");
            partyFilter.Add("achololic", "food");
            partyFilter.Add("red", "food");
            partyFilter.Add("club", "food");
            partyFilter.Add("bar", "food");
            partyFilter.Add("clubbing", "food");
            partyFilter.Add("partying", "food");
            partyFilter.Add("dance", "food");
            partyFilter.Add("danced", "food");
            partyFilter.Add("dancing", "food");
            partyFilter.Add("grind", "food");
            partyFilter.Add("pole", "food");
            partyFilter.Add("cab", "food");
            partyFilter.Add("passedout", "food");
            partyFilter.Add("hangover", "food");
            partyFilter.Add("headache", "food");
            partyFilter.Add("dress", "food");
            partyFilter.Add("belt", "food");


            starcraftFilter.Add("idra", "SC");
            starcraftFilter.Add("huk", "SC");
            starcraftFilter.Add("liquid", "SC");
            starcraftFilter.Add("tlo", "SC");
            starcraftFilter.Add("boxer", "SC");
            starcraftFilter.Add("nada", "SC");
            starcraftFilter.Add("micro", "SC");
            starcraftFilter.Add("teamliquid", "SC");
            starcraftFilter.Add("macro", "SC");
            starcraftFilter.Add("artosis", "SC");
            starcraftFilter.Add("tasteless", "SC");
            starcraftFilter.Add("husky", "SC");
            starcraftFilter.Add("bo5", "SC");
            starcraftFilter.Add("bo3", "SC");
            starcraftFilter.Add("xel'naga", "SC");
            starcraftFilter.Add("protoss", "SC");
            starcraftFilter.Add("terran", "SC");
            starcraftFilter.Add("zerg", "SC");
            starcraftFilter.Add("zergling", "SC");
            starcraftFilter.Add("stim", "SC");
            starcraftFilter.Add("zealot", "SC");
            starcraftFilter.Add("forcefield", "SC");
            starcraftFilter.Add("imba", "SC");
            starcraftFilter.Add("patch", "SC");
            starcraftFilter.Add("jinro", "SC");
            starcraftFilter.Add("infested", "SC");
            starcraftFilter.Add("archon", "SC");
            starcraftFilter.Add("gsl", "SC");
            starcraftFilter.Add("korea", "SC");
            starcraftFilter.Add("progamer", "SC");

            occasionFilter.Add("birthday", "ocassion");
            occasionFilter.Add("birthday!", "ocassion");
            occasionFilter.Add("anniversary", "ocassion");
            occasionFilter.Add("appointment", "ocassion");
            occasionFilter.Add("new years", "ocassion");
            occasionFilter.Add("canada day", "ocassion");
            occasionFilter.Add("national", "ocassion");
            occasionFilter.Add("holiday", "ocassion");
            occasionFilter.Add("weekend", "ocassion");
            occasionFilter.Add("vacation", "ocassion");
            occasionFilter.Add("time off", "ocassion");
            occasionFilter.Add("christmas", "ocassion");
            occasionFilter.Add("halloween", "ocassion");
            occasionFilter.Add("thanksgiving", "ocassion");
            occasionFilter.Add("day", "ocassion");
            occasionFilter.Add("valentine", "ocassion");
            occasionFilter.Add("valentines", "ocassion");
            occasionFilter.Add("gift", "ocassion");
            occasionFilter.Add("gifts", "ocassion");
            occasionFilter.Add("present", "ocassion");
            occasionFilter.Add("presents", "ocassion");
            occasionFilter.Add("chocolate", "ocassion");
            occasionFilter.Add("rose", "ocassion");
            occasionFilter.Add("roses", "ocassion");
            occasionFilter.Add("marriage", "ocassion");
            occasionFilter.Add("married", "ocassion");
            occasionFilter.Add("propose", "ocassion");
            occasionFilter.Add("proposed", "ocassion");

            politicalFilter.Add("obama", "ocassion");
            politicalFilter.Add("president", "ocassion");
            politicalFilter.Add("speech", "ocassion");
            politicalFilter.Add("politics", "ocassion");
            politicalFilter.Add("senate", "ocassion");
            politicalFilter.Add("provincial", "ocassion");
            politicalFilter.Add("election", "ocassion");
            politicalFilter.Add("vote", "ocassion");
            politicalFilter.Add("voting", "ocassion");
            politicalFilter.Add("vice-president", "ocassion");

        }

        public IEnumerable<TwitterStatus> GetTimeLine() {
            //var query = FluentTwitter.CreateRequest().Statuses().OnPublicTimeline().AsJson();
            var authenticated = FluentTwitter.CreateRequest().AuthenticateWith("o2sVvHK5zjoiQ2DAMt6MfQ", "KZRgT1HecEkEzoADOcgxZWPL0aXxhQiO8Vr0TM", "33079040-WWXvpiGMU8eUm7tDp3qyNmvcM66a0bgZzWgFimes7", "Du6NGU56PVPTSj5WpGrKblJ9XQN1GAGDnnubos1pE");
            var query = authenticated.Statuses().OnPublicTimeline().AsJson();
            IEnumerable<TwitterStatus> publicTimeLine = query.Request();
            //IEnumerable<TwitterStatus> publicTimeLine = TestPollFood();
            return publicTimeLine;
        }

        public void FilterTimeLine(IEnumerable<TwitterStatus> publicTimeLine, Dictionary<string, string> categoryTweets, Dictionary<string, string> categoryFilter)
        {
            string tempLower = "";

            foreach (var tweet in publicTimeLine)
            {
                if (!String.IsNullOrEmpty(tweet.Text) && (!categoryTweets.ContainsKey(tweet.Text)))
                {
                    tempLower = tweet.Text.ToLower();
                    string[] scannedTweet = tempLower.Split(' ');
                    foreach (var word in scannedTweet)
                    {
                        if (categoryFilter.ContainsKey(word))
                        {
                            /*string tempstr2 = tweet.RawSource.Substring(tweet.RawSource.LastIndexOf("retweeted"));
                            int tempindex3 = tweet.RawSource.LastIndexOf("retweeted") + 11;
                            int tempindex4 = tempstr2.IndexOf(",") - 11;
                            if (tweet.RawSource.Substring(tempindex3, tempindex4) == "false")
                            {*/
                            categoryTweets.Add(tweet.Text, getTweetKey(tweet));
                            //}
                            break;
                        }
                    }
                }
            }
        }

        public string getTweetKey(TwitterStatus tweet)
        {
            if (tweet.RawSource.LastIndexOf("screen_name") > 0)
            {
                string tempstr = tweet.RawSource.Substring(tweet.RawSource.LastIndexOf("screen_name"));
                int tempindex = tweet.RawSource.LastIndexOf("screen_name") + 15;
                int tempindex2 = tempstr.IndexOf(",") - 16;
                return /*"tweet.User: " + tweet.User + "<br>" +
                   "tweet.RetweetedStatus: " + tweet.RetweetedStatus + "<br>" +
                   "tweet.Location: " + tweet.Location + "<br>" +
                   "tweet.Id: " + tweet.Id + "<br>" +
                   "tweet.Entities: " + tweet.Entities + "<br>" +
                   "tweet.Author: " + tweet.Author + "<br>" +
                   "tweet.RawSource: " + tweet.RawSource + "<br>" +*/
                    //tweet.RawSource.Contains("screen_name") + "<br>" +  //tweet.RawSource.Substring(tweet.RawSource.LastIndexOf("screen_name:")) + "<br>" +
                   tweet.RawSource.Substring(tempindex, tempindex2) +
                   ": " + "[" + tweet.CreatedDate + "] : " + tweet.Text;
                //return tweet.User + " " + "[" + tweet.CreatedDate + "] : " + tweet.Text;
            }
            else
            {
                return tweet.Text;
            }


        }

        public string ConcatTweets(Dictionary<string, string> categoryTweets)
        {
            string allTweets = "";

            foreach (var entry in categoryTweets)
            {
                allTweets += entry.Value + "<br><br>";
            }

            if (!String.IsNullOrEmpty(allTweets))
            {
                return allTweets + "<img src=../Images/voteUp.png></img><br>\n";
            }
            else
            {
                return "";//"Did not collect any food tweets. There may be a connection issue, no new food tweets, or you are not polling. <br><br>";
            }
        }

        public String Index()
        {
            return "";
        }

    }
}

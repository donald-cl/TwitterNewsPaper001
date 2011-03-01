using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TwitterNewsPaper001.Controllers
{
    public class pollCelebrityController : Controller
    {
        private PublicTimeLineController pubtl = new PublicTimeLineController();

        public String Index()
        {
            //var query = FluentTwitter.CreateRequest().Statuses().OnPublicTimeline().AsJson();
            var authenticated = FluentTwitter.CreateRequest().AuthenticateWith("o2sVvHK5zjoiQ2DAMt6MfQ", "KZRgT1HecEkEzoADOcgxZWPL0aXxhQiO8Vr0TM", "33079040-WWXvpiGMU8eUm7tDp3qyNmvcM66a0bgZzWgFimes7", "Du6NGU56PVPTSj5WpGrKblJ9XQN1GAGDnnubos1pE");
            var query = authenticated.Statuses().OnPublicTimeline().AsJson();
            IEnumerable<TwitterStatus> publicTimeLine = query.Request();
            //IEnumerable<TwitterStatus> publicTimeLine = TestPollcelebrity();

            pubtl.InitializeFilters();

            string tempLower = "";

            foreach (var tweet in publicTimeLine)
            {
                if (!String.IsNullOrEmpty(tweet.Text) && (!pubtl.celebrityTweets.ContainsKey(tweet.Text)))
                {
                    tempLower = tweet.Text.ToLower();
                    string[] scannedTweet = tempLower.Split(' ');
                    foreach (var word in scannedTweet)
                    {
                        if (pubtl.celebrityFilter.ContainsKey(word))
                        {
                            /*string tempstr2 = tweet.RawSource.Substring(tweet.RawSource.LastIndexOf("retweeted"));
                            int tempindex3 = tweet.RawSource.LastIndexOf("retweeted") + 11;
                            int tempindex4 = tempstr2.IndexOf(",") - 11;
                            if (tweet.RawSource.Substring(tempindex3, tempindex4) == "false")
                            {*/
                            pubtl.celebrityTweets.Add(tweet.Text, getTweetKey(tweet));
                            //}
                            break;
                        }
                    }
                }
            }


            foreach (var entry in pubtl.celebrityTweets)
            {
                pubtl.allcelebrityTweets += entry.Value + "<br><br>";
            }

            if (!String.IsNullOrEmpty(pubtl.allcelebrityTweets))
            {
                return pubtl.allcelebrityTweets + "<img src=../Images/voteUp.png></img><br>\n";
            }
            else
            {
                return "";//"Did not collect any celebrity tweets. There may be a connection issue, no new celebrity tweets, or you are not polling. <br><br>";
            }
        }

        private static string getTweetKey(TwitterStatus tweet)
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

        private static IEnumerable<TwitterStatus> TestPollcelebrity()
        {
            var authenticated = FluentTwitter.CreateRequest().AuthenticateWith("o2sVvHK5zjoiQ2DAMt6MfQ", "KZRgT1HecEkEzoADOcgxZWPL0aXxhQiO8Vr0TM", "33079040-WWXvpiGMU8eUm7tDp3qyNmvcM66a0bgZzWgFimes7", "Du6NGU56PVPTSj5WpGrKblJ9XQN1GAGDnnubos1pE");
            var query = authenticated.Statuses().OnPublicTimeline().AsJson();
            IEnumerable<TwitterStatus> publicTimeLine = query.Request();

            foreach (var tweet in publicTimeLine)
            {
                tweet.Text += " film";
            }

            return publicTimeLine;
        }


    }

}

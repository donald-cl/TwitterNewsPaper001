using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TwitterNewsPaper001.Controllers
{
    public class pollPartyController : Controller
    {
        private PublicTimeLineController pubtl = new PublicTimeLineController();
        private Boolean debug = false;

        public String Index()
        {

            IEnumerable<TwitterStatus> publicTimeLine = pubtl.GetTimeLine();
            if (debug) { publicTimeLine = TestPoll("shot"); }
            pubtl.InitializeFilters();
            pubtl.FilterTimeLine(publicTimeLine, pubtl.partyTweets, pubtl.partyFilter);
            return pubtl.ConcatTweets(pubtl.partyTweets);
        }

        private static IEnumerable<TwitterStatus> TestPoll(string testValue)
        {
            var authenticated = FluentTwitter.CreateRequest().AuthenticateWith("o2sVvHK5zjoiQ2DAMt6MfQ", "KZRgT1HecEkEzoADOcgxZWPL0aXxhQiO8Vr0TM", "33079040-WWXvpiGMU8eUm7tDp3qyNmvcM66a0bgZzWgFimes7", "Du6NGU56PVPTSj5WpGrKblJ9XQN1GAGDnnubos1pE");
            var query = authenticated.Statuses().OnPublicTimeline().AsJson();
            IEnumerable<TwitterStatus> publicTimeLine = query.Request();

            foreach (var tweet in publicTimeLine)
            {
                tweet.Text += (" " + testValue);
            }

            return publicTimeLine;
        }

    }

}

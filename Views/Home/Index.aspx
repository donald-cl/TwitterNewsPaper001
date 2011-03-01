<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<script type="text/javascript">

    var delay = 10000;

    function getFoodTweets() {
        $.ajax({
            url: "/pollFood/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Food");
                    pElem.innerHTML += (html);
                setTimeout("getFoodTweets()", delay);
            }
        });
    }
    function getCelebrityTweets() {
        $.ajax({
            url: "/pollCelebrity/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Celebrity");
                pElem.innerHTML += (html);
                setTimeout("getCelebrityTweets()", delay);
            }
        });
    }
    function getWeatherTweets() {
        $.ajax({
            url: "/pollWeather/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Weather");
                pElem.innerHTML += (html);
                setTimeout("getWeatherTweets()", delay);
            }
        });
    }
    function getPoliticalTweets() {
        $.ajax({
            url: "/pollPolitical/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Political");
                pElem.innerHTML += (html);
                setTimeout("getPoliticalTweets()", delay);
            }
        });
    }
    function getOccasionTweets() {
        $.ajax({
            url: "/pollOccasion/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Occasion");
                pElem.innerHTML += (html);
                setTimeout("getOccasionTweets()", delay);
            }
        });
    }
    function getPartyTweets() {
        $.ajax({
            url: "/pollParty/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Party");
                pElem.innerHTML += (html);
                setTimeout("getPartyTweets()", delay);
            }
        });
    }
    function getSportsTweets() {
        $.ajax({
            url: "/pollSports/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Sports");
                pElem.innerHTML += (html);
                setTimeout("getSportsTweets()", delay);
            }
        });
    }
    function getTechnologyTweets() {
        $.ajax({
            url: "/pollTechnology/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Technology");
                pElem.innerHTML += (html);
                setTimeout("getTechnologyTweets()", delay);
            }
        });
    }
    function getRelationshipTweets() {
        $.ajax({
            url: "/pollRelationship/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Relationship");
                pElem.innerHTML += (html);
                setTimeout("getRelationshipTweets()", delay);
            }
        });
    }
    function getMusicTweets() {
        $.ajax({
            url: "/pollMusic/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Music");
                pElem.innerHTML += (html);
                setTimeout("getMusicTweets()", delay);
            }
        });
    }
    function geStarcraftTweets() {
        $.ajax({
            url: "/pollStarcraft/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById("Starcraft");
                pElem.innerHTML += (html);
                setTimeout("getStarcraftTweets()", delay);
            }
        });
    }
    setTimeout("getFoodTweets()", delay)
    setTimeout("getCelebrityTweets()", 3000)
    setTimeout("getWeatherTweets()", 6000)
    setTimeout("getPoliticalTweets()", 12000)
    setTimeout("getPartyTweets()", 1000)
    setTimeout("getOccasionTweets()", 15000)
    setTimeout("getSportsTweets()", 18000)
    setTimeout("getMusicTweets()", 21000)

getSportsTweets();
getTechnologyTweets();
getRelationshipTweets();
getStarcraftTweets();
</script>

    <h2>Sports</h2><p id="Sports">
    </p>

    <h2>Music</h2><p id="Music">
    </p>

    <h2>Weather</h2><p id="Weather">
    </p>

    <h2>Technology</h2><p id="Technology">
    </p>

    <h2>Celebrity</h2><p id="Celebrity">
    </p>

    <h2>Food</h2><p id="Food">
    </p>

    <h2>Relationship</h2><p id="Relationship">
    </p>

    <h2>Starcraft</h2><p id="Starcraft">
    </p>

    <h2>Political</h2><p id="Political">
    </p>

    <h2>Occasion</h2><p id="Occasion">
    </p>
        
    <h2>Party</h2><p id="Party">
    </p>

    <h2>Misc Tweets</h2><p id="Misc">
    </p>
    
    <h2>All Tweets</h2><p id="All">
    </p>

</asp:Content>

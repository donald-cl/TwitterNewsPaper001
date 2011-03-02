<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<script type="text/javascript">

    var delay = 10000;

    function getTweets(type) {

        var recurse = function () { getTweets(type); };

        $.ajax({
            url: "/poll"+type+"/Index",
            cache: false,
            success: function (html) {
                pElem = document.getElementById(type);
                pElem.innerHTML += (html);
                setTimeout(recurse, delay);
            }
        });       
    }

    setTimeout(getTweets("Food"), 4000)
    setTimeout(getTweets("Celebrity"), 9000)
    setTimeout(getTweets("Weather"), 6000)
    setTimeout(getTweets("Political"), 12000)
    setTimeout(getTweets("Party"), 1000)
    setTimeout(getTweets("Occassion"), 15000)
    setTimeout(getTweets("Sports"), 18000)
    setTimeout(getTweets("Technology"), 20000)
    setTimeout(getTweets("Relationship"), 23000)
    setTimeout(getTweets("Starcraft"), 26000)

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

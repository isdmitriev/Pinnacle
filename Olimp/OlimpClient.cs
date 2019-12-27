using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System.Threading.Tasks;
using Olimp.Dto;
using System.Globalization;
using Olimp.Parsers;
using System.Threading;
using System.Collections.Concurrent;
using System.Net.Http;
namespace Olimp
{


    public static class Extensions
    {
      
        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) 
            {
                end = source.Length + end;
            }
            int len = end - start;               
            return source.Substring(start, len); 
        }
    }


    public class OlimpLeague
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }

    public class OlimpEvent
    {
        public string EventId { get; set; }
        public string Dateadded { get; set; }
        public DateTime ? StartDate { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string LeagueName { get; set; }





    }

    public interface IOlimpclient
    {
        Task<List<OlimpLeague>> GetLeagues();

        Task<List<OlimpEvent>> GetOlimpEvents();

        Task<List<OlimpEvent>> GetOlimpEventsParalel();

        Task<List<OlimpOddEvent>> GetOdds();

        Task<List<OlimpOddEvent>> GetTodayPrematchOdds(List<OlimpEvent> olimpEvents);

    }

   public class OlimpClient:IOlimpclient
    {
        private readonly WebClient _webClient = new WebClient();
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string _baseUrl = "https://www.betolimp.com";
        private readonly OlimpOddsHtmlParser _htmlOddsParse = new OlimpOddsHtmlParser();
        public OlimpClient()
        {

        }

        public async Task<List<OlimpLeague>> GetLeagues()
        {
            List<OlimpLeague> resultLeagues = new List<OlimpLeague>();
            string url = "/en/sports/champs/football-betting";

            HtmlNode documentNode = this.GetDocumentNodeByUrl(url);
            if (documentNode != null)
            {
                
                
                    HtmlNode leaguesDiv = documentNode.QuerySelector("div.sport_matches:nth-child(1)");

                    foreach (HtmlNode leagueNode in leaguesDiv.ChildNodes)
                    {
                        if (leagueNode.OriginalName == "div" && this.GetAtributeValueByName(leagueNode, "class") == "s_m_item")
                        {

                        try
                        {
                            foreach (HtmlNode node in leagueNode.ChildNodes)
                            {
                                if (node.OriginalName == "div" && this.GetAtributeValueByName(node, "class") == "s_m_i_name")
                                {
                                    OlimpLeague olimpLeague = new OlimpLeague();
                                    olimpLeague.Name = node.ChildNodes[1].InnerText;
                                    olimpLeague.Href = this.GetAtributeValueByName(node.ChildNodes[1], "href");
                                    olimpLeague.Id = this.GetLeagueId(olimpLeague.Href);

                                    if (olimpLeague.Name.Contains("Special offers") == true || olimpLeague.Name.Contains("Outrights") == true || olimpLeague.Name.Contains("Statistics") || olimpLeague.Name.Contains("Draw") == true)
                                    {
                                        continue;
                                    }


                                    resultLeagues.Add(olimpLeague);
                                }

                            }
                        }

                        catch(Exception ex)
                        {
                            continue;
                        }
                        }

                    }
                

              
            }

            else
            {
                return null;
            }

            return resultLeagues;
        }

        public async Task<List<OlimpEvent>> GetOlimpEvents()
        {
            List<OlimpLeague> olimpLeagues = await this.GetLeagues();

            if (olimpLeagues != null)
            {
                List<OlimpEvent> resultEvents = new List<OlimpEvent>();
                foreach (OlimpLeague league in olimpLeagues)
                {



                    List<OlimpEvent> events = await this.GetEventsByLeague(league);
                    if (events != null)
                    {

                        resultEvents.AddRange(events);
                    }
                }
                return resultEvents;
            }
            else
            {
                return null;
            }

            
        }


        public async Task<List<OlimpEvent>> GetOlimpEventsParalel()
        {
            List<OlimpLeague> olimpLeagues = await this.GetLeagues();
            ConcurrentBag<OlimpEvent> events = new ConcurrentBag<OlimpEvent>();
            List<OlimpEvent> result = new List<OlimpEvent>();
            ParallelLoopResult loopResult = Parallel.ForEach(olimpLeagues, league =>
            {
                List<OlimpEvent> events2 =this.GetEventsByLeague(league).Result;
                if (events2 != null)
                {
                    foreach (OlimpEvent olimpEvent in events2)
                    {
                        events.Add(olimpEvent);
                    }
                }
            }
            );

            foreach(OlimpEvent resultEvent in events)
            {
                result.Add(resultEvent);
            }

            return result;
           

        }


        public async Task<List<OlimpEvent>> GetEventsByLeague(OlimpLeague league)
        {
            List<OlimpEvent> events = new List<OlimpEvent>();
            string url = league.Href;
            
            
                HtmlNode documentNode = this.GetDocumentNodeByUrl(url);
            if (documentNode != null)
            {

                try
                {
                  HtmlNode eventsDiv = documentNode.QuerySelector(".to_header");

                   HtmlNodeCollection nodes = eventsDiv.ChildNodes;

                    for (int i = 0; i < nodes.Count; i++)
                    {
                        if (nodes[i].OriginalName == "div" && this.GetAtributeValueByName(nodes[i], "data-id") == league.Id)
                        {
                            HtmlNode chListNode = nodes[i + 2];


                            foreach (HtmlNode node in chListNode.ChildNodes)
                            {
                                if (node.OriginalName == "div" && this.GetAtributeValueByName(node, "class") == "ch_line")
                                {
                                    OlimpEvent olimpEvent = this.GetOlimpEventByNode(node);
                                    olimpEvent.LeagueName = league.Name;
                                    olimpEvent.Dateadded = DateTime.Now.ToString();


                                    events.Add(olimpEvent);
                                }
                            }





                        }
                    }


                }

                catch (Exception ex)
                {
                    return null;
                }
            }

            else
            {
                return null;
            }

            return events;
        }

      

        public async Task<List<OlimpOddEvent>> GetOdds()
        {
            List<OlimpOddEvent> resultList = new List<OlimpOddEvent>();
            List<OlimpEvent> olimpEvents = await this.GetOlimpEventsParalel();
            ConcurrentBag<OlimpOddEvent> events = new ConcurrentBag<OlimpOddEvent>();

            ParallelLoopResult result = Parallel.ForEach(olimpEvents, olimpEv =>
            {
                OlimpOddEvent olimpOddEvent = this.GetOddsByEventId(olimpEv).Result;
                if (olimpOddEvent != null)
                {
                    events.Add(olimpOddEvent);
                }
            }
            );

            foreach(OlimpOddEvent oddEvent in events)
            {
                resultList.Add(oddEvent);
            }

            return resultList;
        }

        public async Task<List<OlimpOddEvent>> GetTodayPrematchOdds(List<OlimpEvent> olimpEvents)
        {
            List<OlimpOddEvent> resultList = new List<OlimpOddEvent>();
           
            ConcurrentBag<OlimpOddEvent> events = new ConcurrentBag<OlimpOddEvent>();

            ParallelLoopResult result = Parallel.ForEach(olimpEvents, olimpEv =>
            {
                OlimpOddEvent olimpOddEvent = this.GetOddsByEventId(olimpEv).Result;
                if (olimpOddEvent != null)
                {
                    events.Add(olimpOddEvent);
                }
            }
            );

            foreach (OlimpOddEvent oddEvent in events)
            {
                resultList.Add(oddEvent);
            }

            return resultList;
        }

        public async Task<OlimpOddEvent> GetOddsByEventId(OlimpEvent olimpEvent)
        {
            
            
                string url = "/en/sports/match/" + olimpEvent.EventId;
                HtmlNode documentNode = this.GetDocumentNodeByUrl(url);
            if (documentNode != null)
            {

                HtmlNode oddsContainer = documentNode.QuerySelector(".coef");

                MoneyLine moneyLine = new MoneyLine();
                DoubleChance doubleChance = new DoubleChance();
                List<Total> totals = new List<Total>();
                List<Handicap> handicaps = new List<Handicap>();

                List<Total> homeTotals = new List<Total>();
                List<Total> awayTotals = new List<Total>();

                OlimpOddEvent olimpOddEvent = new OlimpOddEvent();



                try
                {

                    foreach (HtmlNode node in oddsContainer.ChildNodes)
                    {
                        if (node.OriginalName == "div" && this.GetAtributeValueByName(node, "class") == "")
                        {


                            foreach (HtmlNode htmlNode in node.ChildNodes)
                            {
                                if (htmlNode.OriginalName == "div" && this.GetAtributeValueByName(htmlNode, "class") == "livelineheader")
                                {
                                    string type = this.GetMarketTypeByLiveheaderNode(htmlNode);

                                    if (type == "FULL TIME RESULT")

                                    {
                                        moneyLine = this.getMoneylineFoEvent(node, olimpEvent.EventId);
                                    }


                                    if (type == "DOUBLE CHANCE")
                                    {
                                        doubleChance = this.getDoubleChanceFoEvent(node, olimpEvent.EventId);

                                    }
                                    if (type == "TOTAL GOALS")
                                    {
                                        Total t = this.GetTotalForEvent(node, olimpEvent.EventId);
                                        if (t != null)
                                        {
                                            totals.Add(t);
                                        }
                                            
                                    }

                                    if (type == "ALTERNATIVE TOTAL GOALS")
                                    {
                                        List<Total> totals2 = this.GetTotalGoals(node, olimpEvent.EventId);
                                        if (totals2 != null)
                                        {
                                            totals.AddRange(totals2);
                                        }

                                    }
                                    if (type == "HANDICAP RESULT")
                                    {
                                        Handicap h = this.GetHandicap(node, olimpEvent.EventId);
                                        if (h != null)
                                        {
                                            handicaps.Add(h);
                                        }
                                    
                                    }

                                    if (type == "ALTERNATIVE HANDICAP RESULT")
                                    {
                                        List<Handicap> hdps = this.GetHandicaps(node, olimpEvent.EventId);
                                        if (hdps != null)
                                        {
                                            handicaps.AddRange(hdps);
                                        }
                                    }


                                    if (type == "TEAM TOTAL")
                                    {
                                        var result = this.GetTeamTotals(node, olimpEvent);
                                        if (result.home != null)
                                        {

                                            awayTotals = result.away;
                                            homeTotals = result.home;
                                        }

                                    }


                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }





                olimpOddEvent.moneyLine = moneyLine;
                olimpOddEvent.doubleChance = doubleChance;
                olimpOddEvent.Totals = totals;
                olimpOddEvent.Handicaps = handicaps;
                olimpOddEvent.AwayTotals = awayTotals;
                olimpOddEvent.HomeTotals = homeTotals;


                olimpOddEvent.EventId = olimpEvent.EventId;
                olimpOddEvent.HomeTeam = olimpEvent.HomeTeam;
                olimpOddEvent.AwayTeam = olimpEvent.AwayTeam;
                olimpOddEvent.LeagueName = olimpEvent.LeagueName;
                olimpOddEvent.StartDate = olimpEvent.StartDate;
                olimpOddEvent.DateAdded = DateTime.Now;

                return olimpOddEvent;

            }
            else
            {
                return null;
            }
           
        }


        private string GetMarketTypeByLiveheaderNode(HtmlNode headerNode)
        {
            string type = "";
            try
            {
                type = headerNode.ChildNodes[1].ChildNodes[3].InnerText;
            }
            catch(Exception ex)
            {
                return "";
            }
            return type;
        }
        private OlimpEvent GetOlimpEventByNode(HtmlNode eventInformContainer)
        {
            OlimpEvent olimpEvent = new OlimpEvent();
            olimpEvent.EventId = this.GetAtributeValueByName(eventInformContainer, "data-id");

            string StartDate = eventInformContainer.ChildNodes[1].ChildNodes[1].ChildNodes[1].InnerText.Replace("&nbsp;", " ");

            string teams = eventInformContainer.ChildNodes[1].ChildNodes[1].ChildNodes[3].InnerText;

            var eventTeams = this.GetHomeAwayTeams(teams);
            olimpEvent.HomeTeam = eventTeams.HomeTeam;
            olimpEvent.AwayTeam = eventTeams.AwayTeam;

            olimpEvent.StartDate = new OlimpDatetimeconverter().GetDateTimeFull(StartDate);

            return olimpEvent;

        }

        private HtmlNode GetDocumentNodeByUrl(string url)
        {
            HtmlNode htmlNode = null;
            try
            {
                string fullUrl = this._baseUrl + url;
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(httpClient.GetAsync(fullUrl).Result.Content.ReadAsStringAsync().Result);
                htmlNode = document.DocumentNode;
            }

            catch(Exception ex)
            {
                return null;
            }

            return htmlNode;
        }

        private HtmlNode GetHtmlNodeByCssSelector(string selector,HtmlNode htmlNode)
        {
            return htmlNode.QuerySelector(selector);
        }

        private string GetAtributeValueByName(HtmlNode htmlNode,string atributeName)
        {
            string value = "";
            foreach(HtmlAttribute htmlAttribute in htmlNode.Attributes)
            {
                if (htmlAttribute.Name== atributeName)
                {
                    value = htmlAttribute.Value;
                }
            }
            return value;
        }

        public MoneyLine getMoneylineFoEvent(HtmlNode node,string eventId)
        {
            MoneyLine moneyLine = new MoneyLine();

            try
            {
                foreach (HtmlNode node2 in node.ChildNodes)
                {
                    if (node2.OriginalName == "div" && this.GetAtributeValueByName(node2, "id").StartsWith(eventId) == true)
                    {


                        var result = this._htmlOddsParse.GetLineThree(node2.ChildNodes[1]);

                        moneyLine.Home = result.k1;
                        moneyLine.Draw = result.k2;
                        moneyLine.Away = result.k3;



                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }

            return moneyLine;
        }

        public DoubleChance getDoubleChanceFoEvent(HtmlNode node, string eventId)
        {
            DoubleChance doubleChance = new DoubleChance();

            try
            {
                foreach (HtmlNode node2 in node.ChildNodes)
                {

                    if (node2.OriginalName == "div" && this.GetAtributeValueByName(node2, "id").StartsWith(eventId) == true)
                    {


                        var result = this._htmlOddsParse.GetLineThree(node2.ChildNodes[1]);

                        doubleChance.HomeDraw = result.k1;
                        doubleChance.HomeAway = result.k2;
                        doubleChance.AwayDraw = result.k3;


                    }







                }
            }
            catch(Exception ex)
            {
                return null;
            }

            return doubleChance;

        }

        public Total GetTotalForEvent(HtmlNode node,string eventId)
        {
            Total total = new Total();
            try
            {
                foreach (HtmlNode node2 in node.ChildNodes)
                {

                    if (node2.OriginalName == "div" && this.GetAtributeValueByName(node2, "id").StartsWith(eventId) == true)
                    {


                        var result = this._htmlOddsParse.GetLineTwo(node2.ChildNodes[1]);

                        if (result.name1 != null)
                        {
                            total.Points = this.GetMarketValue(result.name1);
                            total.Under = result.k1;
                            total.Over = result.k2;
                        }
                        else
                        {
                            total.Points = this.GetMarketValue(result.name2);
                            total.Under = result.k1;
                            total.Over = result.k2;
                        }


                    }
                }
            }

            catch(Exception ex)
            {
                return null;
            }

            return total;
        }

        public List<Total> GetTotalGoals(HtmlNode node,string eventId)
        {

            List<Total> totals = new List<Total>();

            try
            {
                foreach (HtmlNode htmlNode in node.ChildNodes)
                {
                    if (htmlNode.OriginalName == "div" && this.GetAtributeValueByName(htmlNode, "id").StartsWith(eventId) == true)
                    {
                        HtmlNodeCollection htmlNodes = htmlNode.ChildNodes;

                        foreach (HtmlNode nodeLineWrapper in htmlNodes)
                        {
                            if (nodeLineWrapper.OriginalName == "div" && this.GetAtributeValueByName(nodeLineWrapper, "class") == "lineWrapper")
                            {
                                Total total = new Total();
                                var result = this._htmlOddsParse.GetLineTwo(nodeLineWrapper);

                                if (result.name1 != null)
                                {
                                    total.Points = this.GetMarketValue(result.name1);
                                    total.Under = result.k1;
                                    total.Over = result.k2;
                                }
                                else
                                {
                                    total.Points = this.GetMarketValue(result.name2);
                                    total.Under = result.k1;
                                    total.Over = result.k2;
                                }

                                totals.Add(total);
                            }

                        }
                    }
                }
            }

            catch(Exception ex)
            {
                return null;
            }

         

            return totals;
        }


        public List<Handicap> GetHandicaps(HtmlNode node, string eventId)
        {

            List<Handicap> handicaps = new List<Handicap>();

            try
            {

                foreach (HtmlNode htmlNode in node.ChildNodes)
                {
                    if (htmlNode.OriginalName == "div" && this.GetAtributeValueByName(htmlNode, "id").StartsWith(eventId) == true)
                    {
                        HtmlNodeCollection htmlNodes = htmlNode.ChildNodes;

                        foreach (HtmlNode nodeLineWrapper in htmlNodes)
                        {
                            if (nodeLineWrapper.OriginalName == "div" && this.GetAtributeValueByName(nodeLineWrapper, "class") == "lineWrapper")
                            {
                                Handicap handicap = new Handicap();
                                var result = this._htmlOddsParse.GetLineTwo(nodeLineWrapper);

                                if (result.name1 != null)
                                {
                                    handicap.HDPHOME = this.GetMarketValue(result.name1);
                                    handicap.HOME = result.k1;
                                    handicap.AWAY = result.k2;
                                }
                                if (result.name2 != null)
                                {
                                    handicap.HDPAWAY = this.GetMarketValue(result.name2);
                                    handicap.HOME = result.k1;
                                    handicap.AWAY = result.k2;
                                }

                                handicaps.Add(handicap);
                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }

          

            return handicaps;
        }


        public Handicap GetHandicap(HtmlNode node, string eventId)
        {

            Handicap resultHandicap = new Handicap();

            try
            {
                foreach (HtmlNode htmlNode in node.ChildNodes)
                {
                    if (htmlNode.OriginalName == "div" && this.GetAtributeValueByName(htmlNode, "id").StartsWith(eventId) == true)
                    {
                        HtmlNodeCollection htmlNodes = htmlNode.ChildNodes;

                        foreach (HtmlNode nodeLineWrapper in htmlNodes)
                        {
                            if (nodeLineWrapper.OriginalName == "div" && this.GetAtributeValueByName(nodeLineWrapper, "class") == "lineWrapper")
                            {

                                var result = this._htmlOddsParse.GetLineTwo(nodeLineWrapper);

                                if (result.name1 != null)
                                {
                                    resultHandicap.HDPHOME = this.GetMarketValue(result.name1);
                                    resultHandicap.HOME = result.k1;
                                    resultHandicap.AWAY = result.k2;
                                }
                                if (result.name2 != null)
                                {
                                    resultHandicap.HDPAWAY = this.GetMarketValue(result.name2);
                                    resultHandicap.HOME = result.k1;
                                    resultHandicap.AWAY = result.k2;
                                }

                                return resultHandicap;
                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }



            return resultHandicap;
        }


        public (List<Total> home, List<Total> away) GetTeamTotals(HtmlNode node, OlimpEvent olimpEvent)
        {

            List<Total> home = new List<Total>();
            List<Total> away = new List<Total>();

            try
            {

                foreach (HtmlNode htmlNode in node.ChildNodes)
                {
                    if (htmlNode.OriginalName == "div" && this.GetAtributeValueByName(htmlNode, "id").StartsWith(olimpEvent.EventId) == true)
                    {
                        HtmlNodeCollection htmlNodes = htmlNode.ChildNodes;

                        foreach (HtmlNode nodeLineWrapper in htmlNodes)
                        {
                            Total teamTotal = new Total();
                            if (nodeLineWrapper.OriginalName == "div" && this.GetAtributeValueByName(nodeLineWrapper, "class") == "lineWrapper")
                            {
                                var result = this._htmlOddsParse.GetLineTwo(nodeLineWrapper);

                                if (result.name1 != null)
                                {
                                    decimal totalValue = this.GetMarketValue(result.name1);
                                    teamTotal.Points = totalValue;
                                    teamTotal.Under = result.k1;


                                }
                                if (result.name2 != null)
                                {
                                    decimal totalValue = this.GetMarketValue(result.name2);
                                    teamTotal.Points = totalValue;
                                    teamTotal.Over = result.k2;


                                }

                                if ((result.name1 != null && result.name1.Contains(olimpEvent.HomeTeam)) || (result.name2 != null && result.name2.Contains(olimpEvent.HomeTeam)))
                                {
                                    home.Add(teamTotal);
                                }

                                else
                                {
                                    away.Add(teamTotal);
                                }


                            }



                        }



                    }

                }

                return (home, away);
            }

            catch (Exception ex)
            {
                return (null, null);
            }


        }





        private decimal GetMarketValue(string name)
        {
            decimal totalPoints = 0.0M;

            int index1 = name.LastIndexOf("(");
            int index2 = name.LastIndexOf(")");

            totalPoints = decimal.Parse(name.Slice(index1+1, index2), CultureInfo.InvariantCulture);

            return totalPoints;
        }





           
        


        private (string HomeTeam,string AwayTeam) GetHomeAwayTeams(string homeawayteams)
        {
            
            if (homeawayteams.Contains("-") == false)
            {
                return ("", "");
            }
            string str = homeawayteams.Replace(" - ", "/");
            int lenght =str.Length;

            int position = str.LastIndexOf("/");

            string awayTeam = str.Substring(position + 1);

            string homeTeam = str.Substring(0, position);
            return (homeTeam, awayTeam);
        }

        private string GetLeagueId(string leagueHref)
        {
            string href = leagueHref;

            int position = href.LastIndexOf("/");

            return href.Substring(position + 1);


        }
    }
}

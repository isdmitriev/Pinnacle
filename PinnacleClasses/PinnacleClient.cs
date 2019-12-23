using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using PinnacleClasses.Dto;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PinnacleClasses.Responses;
using Newtonsoft.Json.Linq;
namespace PinnacleClasses
{
    public class PinnacleClient
    {
        private readonly HttpClient _pinnacleClient = new HttpClient((new HttpClientHandler { AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip }));
        //private string  baseUrl = "https://api.pinnacle.com";

        private string baseUrl = "http://api.ps3838.com";

        public async Task<SportsResponse>  GetSportsAsync()
        {
            string urlPath = "/v1/sports";
            HttpResponseMessage result = this.GetHttpResponseAsync(urlPath).Result;
            string content =await  result.Content.ReadAsStringAsync();
            
            SportsResponse sportsResponse  = JsonConvert.DeserializeObject<SportsResponse>(content);
           
            return sportsResponse;
           
        }

        public async Task<OddResponse>GetOddsBySportIdAsync(string sportId,bool islive)
        {
            string urlPath = "/v1/odds" + "?sportId=29&oddsFormat=DECIMAL";
            if (islive == true)
            {
                urlPath = urlPath + "&isLive=1";
                
            }

           
            HttpResponseMessage result = await this.GetHttpResponseAsync(urlPath);
            string content = await result.Content.ReadAsStringAsync();
            
            OddResponse oddResponse = JsonConvert.DeserializeObject<OddResponse>(content);
            return oddResponse;

        }

        public async Task<FixturesResponse> GetFixturesAsync()
        {
            string urlPath = "/v1/fixtures" + "?sportId=29";
            HttpResponseMessage result = await this.GetHttpResponseAsync(urlPath);
            string content = await result.Content.ReadAsStringAsync();
            
            FixturesResponse fixturesResponse = JsonConvert.DeserializeObject<FixturesResponse>(content);
            return fixturesResponse;
        }

        private async Task<HttpResponseMessage> GetHttpResponseAsync(string apiUrl)
        {
            this.SetHttpClientHeaders();

            HttpResponseMessage httpResponse = await this._pinnacleClient.GetAsync(baseUrl + apiUrl);
            return httpResponse;
            
        }
        private void SetHttpClientHeaders()
        {
           string authHeader = Convert.ToBase64String(
                  Encoding.UTF8.GetBytes(
                      string.Format("{0}:{1}", "AC88000SR9", "at0mSk34!!")));
            if (this._pinnacleClient.DefaultRequestHeaders.Contains("Authorization") == false)
            {
                this._pinnacleClient.DefaultRequestHeaders.Add("Authorization", string.Format("Basic {0}", authHeader));
            }
        }
    }
}

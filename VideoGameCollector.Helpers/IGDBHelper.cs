using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VideoGameCollector.Models;

namespace VideoGameCollector.Helpers
{
    public class IGDBHelper
    {
        public const string BASE_URL = "https://api-v3.igdb.com/";
        public const string BASE_URL_GAMES = BASE_URL + "games";
        public const string API_KEY = "95831edec05ae71ce835a513d2bafcc5";
        public const string GAME_ENDPOINT_SEARCH = "https://api-v3.igdb.com/games?search={0}";

        public static async Task<List<Game>> GetGames(string query)
        {
            List<Game> games = new List<Game>();

            string myJson = "search \"{0}\"; fields name, cover.url, cover.image_id, involved_companies.developer, involved_companies.company.name; limit 500;";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-key", "95831edec05ae71ce835a513d2bafcc5");

                var response = await client.PostAsync(BASE_URL_GAMES, new StringContent(string.Format(myJson, query), Encoding.UTF8, "application/json"));

                var responseString = await response.Content.ReadAsStringAsync();

                games = JsonConvert.DeserializeObject<List<Game>>(responseString);
            }

            return games;
        }
    }
}

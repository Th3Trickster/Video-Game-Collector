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
        public const string API_KEY = "95831edec05ae71ce835a513d2bafcc5";
        public const string GAME_ENDPOINT_SEARCH = "https://api-v3.igdb.com/games?search={0}";
        public const string COVER_ID_URL = "//images.igdb.com/igdb/image/upload/t_thumb/{0}.jpg"; // May need to remove

        public static async Task<List<Game>> GetGames(string query)
        {
            List<Game> games = new List<Game>();

            string myJson = "search \"halo\"; fields name;";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-key", "95831edec05ae71ce835a513d2bafcc5");

                var response = await client.PostAsync("https://api-v3.igdb.com/games", new StringContent(myJson, Encoding.UTF8, "application/json"));

                var responseString = await response.Content.ReadAsStringAsync();

                Debug.Print(responseString);

                games = JsonConvert.DeserializeObject<List<Game>>(responseString);
            }

            return games;
        }
    }
}

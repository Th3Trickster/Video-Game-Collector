using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public static async Task<List<Game>> GetGames(string query)
        {
            List<Game> games = new List<Game>();

            string myJson = "search \"{0}\"; fields name, cover.url, cover.image_id, involved_companies.developer, involved_companies.company.name, aggregated_rating, first_release_date; limit 500;";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-key", "95831edec05ae71ce835a513d2bafcc5");

                var response = await client.PostAsync(BASE_URL_GAMES, new StringContent(string.Format(myJson, query), Encoding.UTF8, "application/json"));

                var responseString = await response.Content.ReadAsStringAsync();

                games = JsonConvert.DeserializeObject<List<Game>>(responseString);
            }

            return games;
        }

        public static async Task<Game> GetGameInformation(int id)
        {
            Game game = new Game();

            string query = "fields name, screenshots.url, screenshots.image_id, cover.url, cover.image_id, first_release_date, involved_companies.developer, involved_companies.company.name, genres.name, platforms.name, storyline, aggregated_rating, release_dates.date, release_dates.platform.name, release_dates.region, summary, involved_companies.publisher, game_modes.name, multiplayer_modes.campaigncoop, multiplayer_modes.dropin, multiplayer_modes.game, multiplayer_modes.lancoop, multiplayer_modes.offlinecoop, multiplayer_modes.offlinecoopmax, multiplayer_modes.offlinemax, multiplayer_modes.onlinecoop, multiplayer_modes.onlinecoopmax, multiplayer_modes.onlinemax, multiplayer_modes.platform.name, multiplayer_modes.splitscreen, multiplayer_modes.splitscreenonline, themes.name, collection.name, player_perspectives.name, franchises.name, game_engines.name, dlcs, bundles, videos.name, videos.video_id, websites.url, websites.category; where id = {0};";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-key", "95831edec05ae71ce835a513d2bafcc5");

                var response = await client.PostAsync(BASE_URL_GAMES, new StringContent(string.Format(query, id), Encoding.UTF8, "application/json"));

                var responseString = await response.Content.ReadAsStringAsync();

                game = (JsonConvert.DeserializeObject<List<Game>>(responseString)).FirstOrDefault();
            }

            return game;
        }

        // Had to use a separate query in order to retrieve the DLCS for a game. The Game itself would return a list of dlc ids (int) and did not have
        // its own request path, so I ended up passing that list of dlc ids from the Game object in the BrowseGamesViewModel and then ran into trouble 
        // with making the query itself because the game query path, when making a call with multiple games, required the string to be wrapped in parenthesis
        // and then have each value separated with a comma, so, I had to use the string.join method in order to achieve this that way there was a comma
        // at the end of each id value and then Deserialized the games into a Game list.
        public static async Task<List<Game>> GetGameDlcs(List<int> dlcId)
        {
            List<Game> game = new List<Game>();
            if (dlcId == null)
            {
                return new List<Game>();
            }
            var convertedList = String.Join(", ", dlcId);

            string query = "fields name, cover.url, cover.image_id; where id = ({0}); limit 500;";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-key", "95831edec05ae71ce835a513d2bafcc5");

                var response = await client.PostAsync(BASE_URL_GAMES, new StringContent(string.Format(query, convertedList), Encoding.UTF8, "application/json"));

                var responseString = await response.Content.ReadAsStringAsync();

                game = JsonConvert.DeserializeObject<List<Game>>(responseString);
            }

            return game;
        }

        public static async Task<List<Game>> GetGameBundles(List<int> gameId)
        {
            List<Game> game = new List<Game>();
            if (gameId == null)
            {
                return new List<Game>();
            }
            var convertedList = String.Join(", ", gameId);

            string query = "fields name, cover.url, cover.image_id; where id = ({0}); limit 500;";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-key", "95831edec05ae71ce835a513d2bafcc5");

                var response = await client.PostAsync(BASE_URL_GAMES, new StringContent(string.Format(query, convertedList), Encoding.UTF8, "application/json"));

                var responseString = await response.Content.ReadAsStringAsync();

                game = JsonConvert.DeserializeObject<List<Game>>(responseString);
            }

            return game;
        }
    }
}
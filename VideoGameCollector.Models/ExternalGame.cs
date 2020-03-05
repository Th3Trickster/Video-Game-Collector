using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/external_games
    public class ExternalGame
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Category Enum
        // The id of the other service
        public int category { get; set; }

        // Unix Time Stamp
        // Date this was initially added to the IGDB database
        public int created_at { get; set; }

        // Reference ID for Game
        // The IGDB ID of the game
        public int game { get; set; }

        // String
        // The name of the game according to the other service
        public string name { get; set; }

        // String
        // The other services ID for this game
        public string uid { get; set; }

        // Unix Time Stamp
        // The last date this entry was updated in the IGDB database
        public int updated_at { get; set; }

        // String
        // The website address (URL) of the item
        public string url { get; set; }

        // Integer
        // The year in full (2018)
        public int? year { get; set; }
    }
}

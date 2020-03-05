using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/achievements
    public class Achievement
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        // Reference ID for Achievement Icon
        // The icon of a specific achievement
        public int achievement_icon { get; set; }

        // Category Enum
        // The platform that a specific achievement belongs to
        public int category { get; set; }

        // Unix Time Stamp
        // Date this was initially added to the IGDB database
        public int created_at { get; set; }

        // String
        // The text explaining how to unlock an achievement
        public string description { get; set; }

        // String
        // The ID given to the achievement by the external service
        public string external_id { get; set; }

        // Reference ID for Game
        // The ID of the game an achievement is connected to
        public int game { get; set; }

        // Language Enum
        // The ID of a region
        public int language { get; set; }

        // Reference ID for Achievement Icon
        // The locked icon of a specific achievement
        public int locked_achievement_icon { get; set; }

        // String
        // The name of the achievement
        public string name { get; set; }

        // Double
        // Approximate percentage of players that have unlocked an achievement
        public double owners_percentage { get; set; }

        // Rank Enum
        // ID of an Achievement Rank
        public int rank { get; set; }

        // String
        // A url-safe, unique, lower-case version of the name
        public string slug { get; set; }

        // Array of Tag Numbers
        // Related entites in the IGDB API
        //public List<TagNumbers> tags { get; set; }

        // Unix Time Stamp
        // The last date this entry was updated in the IGDB database
        public int updated_at { get; set; }
    }
}

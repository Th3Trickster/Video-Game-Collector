using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/characters
    public class Character
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Array of Strings
        // Alternative names for a character
        public List<string> akas { get; set; }

        // String
        // A characters country of origin
        public string country_name { get; set; }

        // Unix Time Stamp
        // Date this was initially added to the IGDB database
        public int created_at { get; set; }

        // String
        // A text describing a character
        public string description { get; set; }

        // Array of Game IDs
        // No description
        public List<int> games { get; set; }

        // Gender Enum
        // No description
        public int gender { get; set; }

        // Reference ID for Character Mug Shot
        // An image depiciting a character
        public int mug_shot { get; set; }

        // String
        // No description
        public string name { get; set; }

        // Array of People IDs
        // Only accessible for Pro & Enterprise users
        public List<int> people { get; set; }

        // String
        // A url-safe, unique, lower-case version of the name
        public string slug { get; set; }

        // Species Enum
        // No description
        public int species { get; set; }

        // Unix Time Stamp
        // The last date this entry was updated in the IGDB database
        public int updated_at { get; set; }

        // String
        // The website address (URL) of the item
        public string url { get; set; }
    }
}

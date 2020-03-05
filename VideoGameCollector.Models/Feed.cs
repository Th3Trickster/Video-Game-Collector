using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/feeds
    public class Feed
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Category Enum
        // The type of feed item
        public int category { get; set; }

        // String
        // The content of the feed item
        public string content { get; set; }

        // Unix Time Stamp
        // Date this was initially added to the IGDB database
        public int created_at { get; set; }

        // Integer
        // Number of likes this feed item has
        public int? feed_likes_count { get; set; }

        // Reference ID for Game Video
        // A video associated with this feed item
        public int? feed_video { get; set; }

        // Array of Game IDs
        // The games connected to this feed item
        public List<int> games { get; set; }

        // String
        // Other meta data
        public string meta { get; set; }

        // Unix Time Stamp
        // The date this item was initially published by the third party
        public int published_at { get; set; }

        // Reference ID for Pulse
        // The pulse article associated with this feed item
        public int pulse { get; set; }

        // String
        // A url-safe, unique, lower-case version of the name
        public string slug { get; set; }

        // String
        // Title of the feed item (usually blank)
        public string title { get; set; }

        // String
        // A unique ID
        public string uid { get; set; }

        // Unix Time Stamp
        // The last date this entry was updated in the IGDB database
        public int updated_at { get; set; }

        // String
        // The website address (URL) of the item
        public string url { get; set; }

        // Integer
        // The user who created the feed item
        public int? user { get; set; }
    }
}

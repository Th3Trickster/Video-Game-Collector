using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/age_ratings
    public class AgeRating
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Category Enum
        // The organization that has issued a specific rating
        public int category { get; set; }

        // Reference ID for Age Rating Content Description
        // No description
        public List<int> content_descriptions { get; set; }

        // Rating Enum
        // The title of an age rating
        public int rating { get; set; }

        // String
        // The url for the image of a age rating
        public string rating_cover_url { get; set; }

        // String
        // A free text motivation a rating
        public string synopsis { get; set; }
    }
}

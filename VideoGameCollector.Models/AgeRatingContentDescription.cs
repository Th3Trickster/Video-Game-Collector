using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/age_rating_content_descriptions
    public class AgeRatingContentDescription
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Category Enum
        // No Description
        public int category { get; set; }

        // String
        // No Description
        public string description { get; set; }
    }
}

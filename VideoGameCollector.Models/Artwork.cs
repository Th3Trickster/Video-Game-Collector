using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/artworks
    public class Artwork
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // boolean
        // No description
        public bool alpha_channel { get; set; }

        // boolean
        // No description
        public bool animated { get; set; }

        // Reference ID for Game
        // The game this artwork is associated with
        public int game { get; set; }

        // Integer
        // The height of the image in pixels
        public int height { get; set; }

        // String
        // The ID of the image used to construct an IGDB image link
        public string image_id { get; set; }

        // String
        // The website address (URL) of the item
        public string url { get; set; }

        // Integer
        // The width of the image in pixels
        public int width { get; set; }
    }
}

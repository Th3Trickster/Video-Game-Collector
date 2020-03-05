using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/alternative_names
    public class AlternativeName
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // String
        // A description of what kind of alternative name it is (Acronym, Working title, Japanese title etc)
        public string comment { get; set; }

        // Reference ID for Game
        // The game this alternative name is associated with
        public int game { get; set; }

        // String
        // An alternative name
        public string name { get; set; }
    }
}

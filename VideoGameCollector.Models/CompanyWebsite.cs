using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/company_websites
    public class CompanyWebsite
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Category Enum
        // The service this website links to
        public int category { get; set; }

        // boolean
        // No description
        public bool trusted { get; set; }

        // String
        // The website address (URL) of the item
        public string url { get; set; }
    }
}

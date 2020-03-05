using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/companies
    public class Company
    {
        // Type is the first line in the comment.
        // Description is the second line in the comment.

        public int id { get; set; }

        // Unix Time Stamp
        // The data when a company got a new ID
        public int? change_date { get; set; }

        // Change Date Category Enum
        // No description
        public int change_date_category { get; set; }

        // Reference ID for Company
        // The new ID for a company that has gone through a merger or restructuring
        public int? changed_company_id { get; set; }

        // Integer
        // ISO 3166-1 country code
        public int? country { get; set; }

        // Unix Time Stamp
        // Date this was initially added to the IGDB database
        public int created_at { get; set; }

        // String
        // A free text description of a company
        public string description { get; set; }

        // Reference ID for Game
        // An array of games that a company had developed
        public List<int> developed { get; set; }

        // Reference ID for Company Logo
        // The company's logo
        public int? logo { get; set; }

        // String
        // No description
        public string name { get; set; }

        // Reference ID for Company
        // A company with a controlling interest in a specific company
        public int? parent { get; set; }

        // Reference ID for Game
        // An array of games that a company has published
        public List<int> published { get; set; }

        // String
        // A url-safe, unique, lower-case version of the name
        public string slug { get; set; }

        // Unix Time Stamp
        // The date a company was founded
        public int? start_date { get; set; }

        // Start Date Category Enum
        // No description
        public int start_date_category { get; set; }

        // Unix Time Stamp
        // The last date this entry was updated in the IGDB database
        public int updated_at { get; set; }

        // String
        // The website address (URL) of the item
        public string url { get; set; }

        // Reference ID for Company Website
        // The companies official websites
        public List<int> websites { get; set; }
    }
}

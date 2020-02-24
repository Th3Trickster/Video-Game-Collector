using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoGameCollector.Models
{
    public class Game
    {
        public int id { get; set; }
        public Cover cover { get; set; }
        public double aggregated_rating { get; set; }
        public List<InvolvedCompany> involved_companies { get; set; }
        public int first_release_date { get; set; }
        public List<Genre> genres { get; set; }
        public List<Platform> platforms { get; set; }
        public string name { get; set; }
        public List<InvolvedCompany> DeveloperCompanies
        {
            get
            {
                if (involved_companies == null)
                {
                    return new List<InvolvedCompany>();
                }
                // Checking to see if developer is true, if its true then it will
                // only show the developer of the game. The api uses a bool for the developer
                // but returns an array of involved companies.
                return involved_companies.Where(c => c.developer == true).ToList();
            }
        }
        public string AggregatedRatingColor
        {
            // Returns a color string based on the aggregated_rating
            get
            {
                if (aggregated_rating <= 100 && aggregated_rating >= 75)
                {
                    return "#66cc33";
                }
                else if (aggregated_rating >= 50 && aggregated_rating <= 74)
                {
                    return "#ffcc33";
                }
                else
                {
                    return "#ff0000";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/games
    public class Game
    {
        public int id { get; set; }
        public double aggregated_rating { get; set; }
        public Collection collection { get; set; }
        public Cover cover { get; set; }
        public List<InvolvedCompany> involved_companies { get; set; }
        public int first_release_date { get; set; }
        public List<Franchise> franchises { get; set; }
        public List<Genre> genres { get; set; }
        public List<Platform> platforms { get; set; }
        public List<Screenshot> screenshots { get; set; }
        public List<ReleaseDate> release_dates { get; set; }
        public List<object> game_engines { get; set; }
        public List<GameMode> game_modes { get; set; }
        public List<MultiplayerMode> multiplayer_modes { get; set; }
        public List<PlayerPerspective> player_perspectives { get; set; }
        public List<Theme> themes { get; set; }
        public string name { get; set; }
        public string storyline { get; set; }
        public string summary { get; set; }
        public string ScreenshotBackground
        {
            get
            {
                if (screenshots == null)
                {
                    return null;
                }
                // Gets the first screenshot image_id for use in the GameDetailsView.
                // This is applied to the background.
                Screenshot firstScreenshot;
                firstScreenshot = screenshots.FirstOrDefault();
                return firstScreenshot.image_id;
            }
        }
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
        public List<InvolvedCompany> Publishers
        {
            get
            {
                if (involved_companies == null)
                {
                    return new List<InvolvedCompany>();
                }
                return involved_companies.Where(c => c.publisher == true).ToList();
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

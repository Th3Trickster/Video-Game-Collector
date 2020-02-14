using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    public sealed class Game
    {
        public int id { get; set; }
        public List<int> age_ratings { get; set; }
        public double aggregated_rating { get; set; }
        public int aggregated_rating_count { get; set; }
        public List<int> alternative_names { get; set; }
        public int category { get; set; }
        public int collection { get; set; }
        public int cover { get; set; }
        public int created_at { get; set; }
        public List<int> external_games { get; set; }
        public int first_release_date { get; set; }
        public int franchise { get; set; }
        public List<int> franchises { get; set; }
        public List<int> game_engines { get; set; }
        public List<int> game_modes { get; set; }
        public List<int> genres { get; set; }
        public List<int> involved_companies { get; set; }
        public List<int> keywords { get; set; }
        public List<int> multiplayer_modes { get; set; }
        public string name { get; set; }
        public List<int> platforms { get; set; }
        public List<int> player_perspectives { get; set; }
        public double popularity { get; set; }
        public int pulse_count { get; set; }
        public double rating { get; set; }
        public int rating_count { get; set; }
        public List<int> release_dates { get; set; }
        public List<int> screenshots { get; set; }
        public List<int> similar_games { get; set; }
        public string slug { get; set; }
        public string storyline { get; set; }
        public string summary { get; set; }
        public List<int> tags { get; set; }
        public List<int> themes { get; set; }
        public int time_to_beat { get; set; }
        public double total_rating { get; set; }
        public int total_rating_count { get; set; }
        public int updated_at { get; set; }
        public string url { get; set; }
        public List<int> videos { get; set; }
        public List<int> websites { get; set; }
        public int? version_parent { get; set; }
        public string version_title { get; set; }
        public List<int> artworks { get; set; }
        public List<int> bundles { get; set; }
        public List<int> dlcs { get; set; }
        public int hypes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/franchises
    public class Franchise
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}

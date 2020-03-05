using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    // Request Path:
    // https://api-v3.igdb.com/collections
    // AKA Series
    public class Collection
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}

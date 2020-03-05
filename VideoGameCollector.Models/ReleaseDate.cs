using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    public class ReleaseDate
    {
        public int id { get; set; }
        public int date { get; set; }
        public Platform platform { get; set; }
    }
}

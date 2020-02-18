using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameCollector.Models
{
    public class InvolvedCompany
    {
        public int id { get; set; }
        public Company company { get; set; }
        public bool developer { get; set; }
    }
}

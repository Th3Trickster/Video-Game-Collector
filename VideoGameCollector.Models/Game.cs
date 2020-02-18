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
        public List<InvolvedCompany> involved_companies { get; set; }
        public string name { get; set; }
        public List<InvolvedCompany> DeveloperCompanies
        {
            get
            {
                if (involved_companies == null)
                {
                    return new List<InvolvedCompany>();
                }
                return involved_companies.Where(c => c.developer == true).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class SchemaItemToolUsageModel
    {
        public int LeagueId { get; set; }

        public string Tier { get; set; }

        public string Location { get; set; }
        
        public bool Admin { get; set; }
    }
}

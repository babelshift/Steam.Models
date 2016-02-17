using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class SchemaRarityModel
    {
        public string Name { get; set; }
        
        public int Value { get; set; }
    
        public string LocKey { get; set; }
        
        public string Color { get; set; }
        
        public string NextRarity { get; set; }
    }
}

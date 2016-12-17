using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.TF2
{
    public class SchemaLevelModel
    {
        public int Level { get; set; }
        
        public int RequiredScore { get; set; }
        
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class SchemaItemAutographModel
    {
        public string DefIndex { get; set; }

        public string Name { get; set; }

        public string Autograph { get; set; }

        public long? WorkshopLink { get; set; }

        public int Language { get; set; }

        public string IconPath { get; set; }

        public string Modifier { get; set; }
    }
}

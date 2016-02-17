using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class ItemBuildGroupSchemaItemModel
    {
        public string Name { get; set; }
        public IList<string> Items { get; set; }
    }
}

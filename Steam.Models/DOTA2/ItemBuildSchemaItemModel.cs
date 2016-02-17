using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class ItemBuildSchemaItemModel
    {
        public string Author { get; set; }
        public string Hero { get; set; }
        public string Title { get; set; }
        
        public IList<ItemBuildGroupSchemaItemModel> Items { get; set; }
    }
}

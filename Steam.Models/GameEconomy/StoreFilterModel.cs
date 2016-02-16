using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class StoreFilterModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UrlHistoryParamName { get; set; }

        public StoreFilterAllElementModel AllElement { get; set; }

        public IReadOnlyCollection<StoreFilterElementModel> Elements { get; set; }

        public int Count { get; set; }
    }
}
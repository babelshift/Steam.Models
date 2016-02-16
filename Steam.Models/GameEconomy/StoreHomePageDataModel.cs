using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class StoreHomePageDataModel
    {
        public int HomeCategoryId { get; set; }

        public IReadOnlyCollection<StorePopularItemModel> PopularItems { get; set; }
    }
}
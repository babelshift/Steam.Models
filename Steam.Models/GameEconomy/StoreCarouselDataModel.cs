using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class StoreCarouselDataModel
    {
        public int MaxDisplayBanners { get; set; }

        public IReadOnlyCollection<StoreBannerModel> Banners { get; set; }
    }
}
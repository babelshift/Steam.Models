using System.Collections.Generic;

namespace Steam.Models.SteamEconomy
{
    public class AssetClassAppDataModel
    {
        public string DefIndex { get; set; }

        public string Quality { get; set; }

        public string Slot { get; set; }

        public IReadOnlyCollection<AssetClassAppDataFilterModel> FilterData { get; set; }

        public IReadOnlyCollection<long> PlayerClassIds { get; set; }

        public string HighlightColor { get; set; }
    }
}
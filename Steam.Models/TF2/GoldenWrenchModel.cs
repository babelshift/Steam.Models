using System;

namespace Steam.Models.TF2
{
    public class GoldenWrenchModel
    {
        public object SteamId { get; set; }

        public DateTime Timestamp { get; set; }

        public int ItemId { get; set; }

        public int WrenchNumber { get; set; }
    }
}
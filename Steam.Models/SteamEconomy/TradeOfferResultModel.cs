using System.Collections.Generic;

namespace Steam.Models.SteamEconomy
{
    public class TradeOfferResultModel
    {
        public TradeOfferModel TradeOffer { get; set; }
        public IList<string> Descriptions { get; set; }
    }
}
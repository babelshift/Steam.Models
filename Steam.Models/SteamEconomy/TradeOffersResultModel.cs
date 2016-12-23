using System.Collections.Generic;

namespace Steam.Models.SteamEconomy
{
    public class TradeOffersResultModel
    {
        public IList<TradeOfferModel> TradeOffersSent { get; set; }
        public IList<TradeOfferModel> TradeOffersReceived { get; set; }
        public IList<string> Descriptions { get; set; }
    }
}
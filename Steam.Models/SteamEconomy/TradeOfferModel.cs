using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public class TradeOfferModel
    {
        public uint TradeOfferId { get; set; }
        public ulong TradePartnerSteamId { get; set; }
        public string Message { get; set; }
        public long TimeExpiration { get; set; }
        public TradeOfferState TradeOfferState { get; set; }
        public IList<TradeAssetModel> ItemsYouWillGive { get; set; }
        public IList<TradeAssetModel> ItemsYouWillReceive { get; set; }
        public bool IsOfferYouCreated { get; set; }
        public long TimeCreated { get; set; }
        public long TimeUpdated { get; set; }
        public bool WasCreatedFromRealTimeTrade { get; set; }
        public long TimeEscrowEnds { get; set; }
        public TradeOfferConfirmationMethod ConfirmationMethod { get; set; }
    }
}

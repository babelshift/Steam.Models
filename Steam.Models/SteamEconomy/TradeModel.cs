using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public class TradeModel
    {
        public ulong TradeId { get; set; }
        public ulong TradeParterSteamId { get; set; }
        public long TimeTradeStarted { get; set; }
        public long TimeEscrowEnds { get; set; }
        public TradeStatus TradeStatus { get; set; }
        public IList<TradedAssetModel> AssetsReceived { get; set; }
        public IList<TradedAssetModel> AssetsGiven { get; set; }
        public IList<TradedCurrencyModel> CurrencyReceived { get; set; }
        public IList<TradedCurrencyModel> CurrencyGiven { get; set; }
    }
}

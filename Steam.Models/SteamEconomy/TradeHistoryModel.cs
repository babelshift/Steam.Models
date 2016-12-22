using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public class TradeHistoryModel
    {
        public uint TotalTradeCount { get; set; }
        public bool AreMoreAvailable { get; set; }
        public IList<TradeModel> Trades { get; set; }
        public IList<string> Descriptions { get; set; }
    }
}

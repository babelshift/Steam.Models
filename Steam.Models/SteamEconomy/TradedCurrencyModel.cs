using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public class TradedCurrencyModel
    {
        public uint AppId { get; set; }
        public uint ContextId { get; set; }
        public uint CurrencyId { get; set; }
        public uint AmountTraded { get; set; }
        public uint ClassId { get; set; }
        public ulong CurrencyIdAfterTrade { get; set; }
        public uint ContextIdAfterTrade { get; set; }
        public ulong CurrencyIdAfterRollback { get; set; }
        public uint ContextIdAfterRollback { get; set; }
    }
}

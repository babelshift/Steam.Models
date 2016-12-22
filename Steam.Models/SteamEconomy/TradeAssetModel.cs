using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public class TradeAssetModel
    {
        public uint AppId { get; set; }
        public uint ContextId { get; set; }
        public ulong AssetId { get; set; }
        public ulong CurrencyId { get; set; }
        public uint ClassId { get; set; }
        public uint InstanceId { get; set; }
        public uint AmountOffered { get; set; }
        public bool IsMissing { get; set; }
    }
}

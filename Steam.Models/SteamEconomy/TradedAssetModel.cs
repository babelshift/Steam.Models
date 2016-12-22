using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.SteamEconomy
{
    public class TradedAssetModel
    {
        public uint AppId { get; set; }
        public uint ContextId { get; set; }
        public ulong AssetId { get; set; }
        public uint AmountTraded { get; set; }
        public uint ClassId { get; set; }
        public uint InstanceId { get; set; }
        public ulong AssetIdAfterTrade { get; set; }
        public ulong ContextIdAfterTrade { get; set; }
        public ulong AssetIdAfterRollback { get; set; }
        public ulong ContextIdAfterRollback { get; set; }
    }
}

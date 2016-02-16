using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class EconItemResultModel
    {
        public int Status { get; set; }

        public int NumBackpackSlots { get; set; }

        public IReadOnlyCollection<EconItemModel> Items { get; set; }
    }
}
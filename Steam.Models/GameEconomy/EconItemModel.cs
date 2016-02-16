using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class EconItemModel
    {
        public long Id { get; set; }

        public long OriginalId { get; set; }

        public int DefIndex { get; set; }
        public int Level { get; set; }
        public int Quality { get; set; }
        public long Inventory { get; set; }
        public int Quantity { get; set; }
        public int Origin { get; set; }
        public IReadOnlyCollection<EconItemEquippedModel> Equipped { get; set; }
        public int Style { get; set; }
        public IReadOnlyCollection<EconItemAttributeModel> Attributes { get; set; }

        public bool? FlagCannotTrade { get; set; }

        public bool? FlagCannotCraft { get; set; }
    }
}
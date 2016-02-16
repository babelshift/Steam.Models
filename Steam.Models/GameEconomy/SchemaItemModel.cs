using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class SchemaItemModel
    {
        public string Name { get; set; }

        public int Defindex { get; set; }

        public string ItemClass { get; set; }

        public string ItemTypeName { get; set; }

        public string ItemName { get; set; }

        public bool ProperName { get; set; }

        public string ItemSlot { get; set; }

        public string ModelPlayer { get; set; }

        public int ItemQuality { get; set; }

        public string ImageInventory { get; set; }

        public int MinIlevel { get; set; }

        public int MaxIlevel { get; set; }

        public string ImageUrl { get; set; }

        public string ImageUrlLarge { get; set; }

        public string CraftClass { get; set; }

        public string CraftMaterialType { get; set; }

        public SchemaCapabilitiesModel Capabilities { get; set; }

        public IReadOnlyCollection<string> UsedByClasses { get; set; }

        public IReadOnlyCollection<SchemaStyleModel> Styles { get; set; }

        public string ItemDescription { get; set; }

        public IReadOnlyCollection<SchemaItemAttributeModel> Attributes { get; set; }

        public string DropType { get; set; }

        public string ItemSet { get; set; }

        public string HolidayRestriction { get; set; }

        public SchemaPerClassLoadoutSlotsModel PerClassLoadoutSlots { get; set; }

        public SchemaToolModel Tool { get; set; }
    }
}
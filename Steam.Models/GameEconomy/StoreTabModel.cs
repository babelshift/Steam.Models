using System.Collections.Generic;

namespace Steam.Models.GameEconomy
{
    public class StoreTabModel
    {
        public string Label { get; set; }

        public string Id { get; set; }

        public object ParentId { get; set; }

        public bool UseLargeCells { get; set; }

        public bool Default { get; set; }

        public IReadOnlyCollection<StoreTabChildModel> Children { get; set; }

        public bool Home { get; set; }

        public long? DropdownPrefabId { get; set; }

        public string ParentName { get; set; }
    }
}
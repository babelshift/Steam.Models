namespace Steam.Models.GameEconomy
{
    public class StoreConfigModel
    {
        public long DropdownId { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; }

        public long DefaultSelectionId { get; set; }
    }
}
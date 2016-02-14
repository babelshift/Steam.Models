namespace Steam.Models.DOTA2
{
    public class GameItemModel
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public bool IsRecipe { get; set; }
        public bool IsAvailableAtSecretShop { get; set; }
        public bool IsAvailableAtSideShop { get; set; }
    }
}
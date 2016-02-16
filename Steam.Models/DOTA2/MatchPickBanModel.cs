namespace Steam.Models.DOTA2
{
    public class MatchPickBanModel
    {
        public bool IsPick { get; set; }

        public int HeroId { get; set; }

        public int Team { get; set; }
        public int Order { get; set; }
    }
}
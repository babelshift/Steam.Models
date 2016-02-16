namespace Steam.Models.SteamCommunity
{
    public class BadgeModel
    {
        public int BadgeId { get; set; }

        public int Level { get; set; }

        public int CompletionTime { get; set; }

        public int Xp { get; set; }

        public int Scarcity { get; set; }

        public int? AppId { get; set; }

        public string CommunityItemId { get; set; }

        public int? BorderColor { get; set; }
    }
}
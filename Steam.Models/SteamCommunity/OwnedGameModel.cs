namespace Steam.Models.SteamCommunity
{
    public class OwnedGameModel
    {
        public int AppId { get; set; }

        public string Name { get; set; }

        public int PlaytimeForever { get; set; }

        public string ImgIconUrl { get; set; }

        public string ImgLogoUrl { get; set; }

        public bool HasCommunityVisibleStats { get; set; }

        public int? Playtime2weeks { get; set; }
    }
}
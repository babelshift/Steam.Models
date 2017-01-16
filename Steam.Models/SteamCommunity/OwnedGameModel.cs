namespace Steam.Models.SteamCommunity
{
    public class OwnedGameModel
    {
        public uint AppId { get; set; }

        public string Name { get; set; }

        public uint PlaytimeForever { get; set; }

        public string ImgIconUrl { get; set; }

        public string ImgLogoUrl { get; set; }

        public bool HasCommunityVisibleStats { get; set; }

        public uint? Playtime2weeks { get; set; }
    }
}
namespace Steam.Models.SteamCommunity
{
    public class RecentlyPlayedGameModel
    {
        public int AppId { get; set; }

        public string Name { get; set; }

        public int Playtime2Weeks { get; set; }

        public int PlaytimeForever { get; set; }

        public string ImgIconUrl { get; set; }

        public string ImgLogoUrl { get; set; }
    }
}
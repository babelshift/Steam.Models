namespace Steam.Models.DOTA2
{
    public class LiveLeagueGamePlayerInfoModel
    {
        public uint AccountId { get; set; }

        public string Name { get; set; }

        public int HeroId { get; set; }

        public int Team { get; set; }
    }
}
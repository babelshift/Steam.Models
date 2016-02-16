namespace Steam.Models.DOTA2
{
    public class LiveLeagueGameTeamRadiantInfoModel
    {
        public string TeamName { get; set; }

        public int TeamId { get; set; }

        public long TeamLogo { get; set; }

        public bool Complete { get; set; }
    }
}